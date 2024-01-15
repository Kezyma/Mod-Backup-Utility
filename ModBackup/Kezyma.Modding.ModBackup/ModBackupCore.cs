using Kezyma.Modding.ModBackup.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kezyma.Modding.ModBackup
{
    public static class ModBackupCore
    {
        public static ModBackup2 MB2;

        #region Paths
        public static string BackupPath => Path.Join(Directory.GetCurrentDirectory(), "Backups");
        public const string ToolsDir = "Tools";
        public const string DocsDir = "Docs";
        public const string GameDir = "Game";
        #endregion

        #region Game List
        private static List<GameSettings> _gameList;
        public static List<GameSettings> GameList => _gameList ??= GetGameList();
        private static List<GameSettings> GetGameList()
        {
            if (!Directory.Exists(BackupPath)) Directory.CreateDirectory(BackupPath);
            return Directory.GetFiles(BackupPath)
                        .Where(x => x.EndsWith("_Config.json"))
                        .Select(x => JsonConvert.DeserializeObject<GameSettings>(File.ReadAllText(x)))
                        .ToList();
        }
            
            
        public static void ReloadGameList() => _gameList = GetGameList();
        public static bool GameHasBackup(string guid) => File.Exists(Path.Join(BackupPath, $"{guid}_Game.zip"));
        #endregion

        #region Backup List
        private static Dictionary<string, List<ModSettings>> _backupList;
        public static Dictionary<string, List<ModSettings>> BackupList => _backupList ??= GetBackupList();
        private static Dictionary<string, List<ModSettings>> GetBackupList() => Directory.GetFiles(BackupPath)
            .Where(x => x.EndsWith("_Backup.json"))
            .Select(x => JsonConvert.DeserializeObject<ModSettings>(File.ReadAllText(x)))
            .GroupBy(x => x.GameGuid)
            .ToDictionary(x => x.Key, x => x.ToList());
        public static void ReloadBackupList() => _backupList = GetBackupList();
        #endregion

        #region Game
        public static void DeleteGame(string guid)
        {
            foreach (var file in Directory.GetFiles(BackupPath).Where(x => x.Contains(guid))) File.Delete(file);
            ReloadGameList();
        }
        public static void AddGame(GameSettings settings)
        {
            File.WriteAllText(Path.Combine(BackupPath, $"{settings.Guid}_Config.json"), JsonConvert.SerializeObject(settings));
            ReloadGameList();
        }
        #endregion

        #region Backup
        public static void DeleteGameBackup(string guid)
        {
            File.Delete(Path.Join(BackupPath, $"{guid}_Game.zip"));
            ReloadBackupList();
        }
        public static void DeleteBackup(string guid)
        {
            foreach (var file in Directory.GetFiles(BackupPath).Where(x => x.Contains(guid))) File.Delete(file);
            ReloadBackupList();
        }
        public static void AddBackup(ModSettings settings)
        {
            File.WriteAllText(Path.Combine(BackupPath, $"{settings.GameGuid}_{settings.ModGuid}_Backup.json"), JsonConvert.SerializeObject(settings));
            ReloadBackupList();
        }
        #endregion

        #region Generic
        public static void SelectFolder(this Dictionary<string, string> dict, string name, Label pathLabel = null)
        {
            using var fs = new FolderBrowserDialog();
            var res = fs.ShowDialog();
            if (res == DialogResult.OK)
            {
                if (dict.ContainsKey(name)) dict[name] = fs.SelectedPath;
                else dict.Add(name, fs.SelectedPath);
                if (pathLabel != null) pathLabel.Text = fs.SelectedPath;
            }
        }
        private static int _totalFiles;
        #endregion

        #region Scanning
        private static int _scannedFiles;
        public static void ScanGame(this BackgroundWorker worker, string guid, string name, Dictionary<string, string> paths)
        {
            try
            {
                var settings = new GameSettings
                {
                    Name = name,
                    ScanDate = DateTime.Now,
                    Guid = guid,
                    Folders = new List<FolderDefinition>()
                };
                worker.ReportProgress(0, "Counting Files");
                _scannedFiles = 0;
                _totalFiles = CountFiles(paths);
                Parallel.ForEach(paths,
                new ParallelOptions { MaxDegreeOfParallelism = 2 },
                dir => settings.Folders.Add(new FolderDefinition
                {
                    Name = dir.Key,
                    Path = dir.Value,
                    Files = worker.GetDirectoryContents(dir.Value)
                }));
                AddGame(settings);
            }
            catch (Exception e)
            {
                worker.ReportProgress(100, $"Scanning Failed: {e.Message}");
            }
        }
        private static int CountFiles(Dictionary<string, string> paths) => paths.Sum(x => Directory.GetFiles(x.Value, "*", SearchOption.AllDirectories).Length);
        private static List<FileDefinition> GetDirectoryContents(this BackgroundWorker worker, string path)
        {
            var res = new List<FileDefinition>();
            Parallel.ForEach(Directory.GetFiles(path), new ParallelOptions { MaxDegreeOfParallelism = 2 }, file =>
            {
                var p = (int)(_scannedFiles / (double)_totalFiles * 100);
                if (p > 100) p = 100;
                worker.ReportProgress(p, $"{_scannedFiles}/{_totalFiles} Scanning {file ?? ""}");
                res.Add(new FileDefinition(file, ComputeHash(file)));
                _scannedFiles++;
            });
            foreach (var dir in Directory.GetDirectories(path))
            {
                var content = worker.GetDirectoryContents(dir);
                res.AddRange(content);
            }
            return res;

        }
        private static string ComputeHash(string path)
        {
            using var md5 = MD5.Create();
            using var stream = File.OpenRead(path);
            return Convert.ToBase64String(md5.ComputeHash(stream));
        }
        #endregion

        #region Backing Up
        private static int _backedUpFiles;
        public static void BackupGame(this BackgroundWorker worker, string guid)
        {
            try
            {
                _backedUpFiles = 0;
                var folders = GameList.FirstOrDefault(x => x.Guid == guid).Folders;
                _totalFiles = folders.SelectMany(x => x.Files).Count();
                var folderPaths = folders.ToDictionary(x => x.Name, x => x.Path);
                var zipPath = Path.Combine(BackupPath, $"{guid}_Game.zip");
                try
                {
                    if (File.Exists(zipPath)) File.Delete(zipPath);
                    using var zippedGame = ZipFile.Open(zipPath, ZipArchiveMode.Create);
                    foreach (var dir in folderPaths) worker.CreateEntryFromDirectory(zippedGame, dir.Value, dir.Key.Replace(' ', '_'));
                }
                catch (Exception e)
                {
                    File.Delete(zipPath);
                    throw e;
                }
            }
            catch (Exception e)
            {
                worker.ReportProgress(100, $"Backing Up Failed: {e.Message}");
            }
        }
        private static void CreateEntryFromDirectory(this BackgroundWorker worker, ZipArchive archive, string path, string name, List<string> validFiles = null)
        {
            string[] files = Directory.GetFiles(path).Concat(Directory.GetDirectories(path)).ToArray();
            foreach (var file in files) worker.CreateEntryFromAny(archive, file, name, validFiles);
        }
        private static void CreateEntryFromAny(this BackgroundWorker worker, ZipArchive archive, string sourceName, string entryName = "", List<string> validFiles = null)
        {
            var fileName = Path.GetFileName(sourceName);
            if (File.GetAttributes(sourceName).HasFlag(FileAttributes.Directory)) worker.CreateEntryFromDirectory(archive, sourceName, Path.Combine(entryName, fileName), validFiles);
            else if (validFiles == null || validFiles.Contains(sourceName))
            {
                var p = (int)(_backedUpFiles / (double)_totalFiles * 100);
                p = p > 100 ? 100 : p;
                worker.ReportProgress(p, $"{_backedUpFiles}/{_totalFiles} Backing Up {sourceName ?? ""}");
                archive.CreateEntryFromFile(sourceName, Path.Combine(entryName, fileName), CompressionLevel.Optimal);
                _backedUpFiles++;
            }
        }
        #endregion

        #region Modding
        public static void ScanChanges(this BackgroundWorker worker, string guid, string name)
        {
            try
            {
                var game = GameList.FirstOrDefault(x => x.Guid == guid);
                var settings = new ModSettings
                {
                    Name = name,
                    BackupDate = DateTime.Now,
                    GameGuid = guid,
                    ModGuid = Guid.NewGuid().ToString(),
                    Folders = new List<string>()
                };
                var newFiles = game.Folders.ToDictionary(x => x.Name, x => new List<string>());
                worker.ReportProgress(0, "Counting Files");
                _scannedFiles = 0;
                _totalFiles = CountFiles(game.Folders.ToDictionary(x => x.Name, x => x.Path));
                Parallel.ForEach(game.Folders, new ParallelOptions { MaxDegreeOfParallelism = 2 }, dir => newFiles[dir.Name].AddRange(worker.GetDirectoryContents(dir.Path).Where(x => !dir.Files.Any(f => f.Path == x.Path && f.Hash == x.Hash)).Select(x => x.Path).ToList()));
                settings.Folders = newFiles.Where(x => x.Value.Any()).Select(x => x.Key).ToList();
                AddBackup(settings);
                worker.BackupChanges(game.Guid, settings.ModGuid, newFiles);
            }
            catch (Exception e)
            {
                worker.ReportProgress(100, $"Scanning Failed: {e.Message}");
            }
        }

        public static void BackupChanges(this BackgroundWorker worker, string gameGuid, string backupGuid, Dictionary<string, List<string>> changedFiles)
        {
            try
            {
                var zipPath = Path.Combine(BackupPath, $"{gameGuid}_{backupGuid}_Backup.zip");
                if (changedFiles != null)
                {
                    worker.ReportProgress(0, "Backing Up");
                    _backedUpFiles = 0;
                    _totalFiles = changedFiles.SelectMany(x => x.Value).Count();
                    try
                    {

                        if (File.Exists(zipPath)) File.Delete(zipPath);
                        using var zippedGame = ZipFile.Open(zipPath, ZipArchiveMode.Create);
                        foreach (var dir in changedFiles)
                        {
                            worker.CreateEntryFromDirectory(zippedGame, GameList.FirstOrDefault(x => x.Guid == gameGuid).Folders.FirstOrDefault(x => x.Name == dir.Key).Path, dir.Key.Replace(' ', '_'), dir.Value);
                        }
                        worker.ReportProgress(100, "Backup Complete");
                    }
                    catch (Exception e)
                    {
                        File.Delete(zipPath);
                        throw e;
                    }
                }
            }
            catch (Exception e)
            {
                worker.ReportProgress(100, $"Backing Up Failed: {e.Message}");
            }
        }
        #endregion

        #region Recording

        private static Dictionary<string, FileSystemWatcher> _folderWatchers;
        private static Dictionary<string, List<string>> _watchedChanges;
        private static GameSettings _recordedGame;
        public static void StartRecord(string guid)
        {
            _recordedGame = GameList.FirstOrDefault(x => x.Guid == guid);
            _folderWatchers = new Dictionary<string, FileSystemWatcher>();
            foreach (var folder in _recordedGame.Folders)
            {
                var fsw = new FileSystemWatcher
                {
                    Path = folder.Path,
                    NotifyFilter = NotifyFilters.LastWrite | NotifyFilters.CreationTime |
                    NotifyFilters.DirectoryName | NotifyFilters.Size | NotifyFilters.FileName |
                    NotifyFilters.Security | NotifyFilters.Attributes,
                    IncludeSubdirectories = true,
                    EnableRaisingEvents = true
                };
                fsw.Changed += new FileSystemEventHandler(RecordChange);
                _folderWatchers.Add(folder.Name, fsw);
            }
        }
        private static void RecordChange(object source, FileSystemEventArgs e)
        {
            var src = (FileSystemWatcher)source;
            var folder = _recordedGame.Folders.FirstOrDefault(x => x.Path == src.Path)?.Name;
            if (File.Exists(e.FullPath))
            {
                if (_watchedChanges == null) _watchedChanges = new Dictionary<string, List<string>>();
                if (!_watchedChanges.ContainsKey(folder)) _watchedChanges.Add(folder, new List<string>());

                var existing = _recordedGame.Folders.SelectMany(x => x.Files).FirstOrDefault(x => x.Path == e.FullPath);
                var isChange = existing == null || existing.Hash != ComputeHash(e.FullPath);

                if (!_watchedChanges[folder].Contains(e.FullPath) && isChange) _watchedChanges[folder].Add(e.FullPath);
            }
            else if (_watchedChanges != null &&
                    _watchedChanges.ContainsKey(folder) &&
                    _watchedChanges[folder].Contains(e.FullPath))
            {
                _watchedChanges[folder].Remove(e.FullPath);
            }
        }
        public static void SaveRecordedChanges(this BackgroundWorker worker, string guid, string name)
        {
            try
            {
                foreach (var fsw in _folderWatchers) fsw.Value.Dispose();
                _folderWatchers = null;

                if (_watchedChanges != null)
                {
                    foreach (var change in _watchedChanges.SelectMany(x => x.Value).ToList())
                    {
                        if (!File.Exists(change))
                        {
                            _watchedChanges.First(x => x.Value.Contains(change)).Value.Remove(change);
                        }
                    }
                    var game = GameList.FirstOrDefault(x => x.Guid == guid);
                    var settings = new ModSettings
                    {
                        Name = name,
                        BackupDate = DateTime.Now,
                        GameGuid = guid,
                        ModGuid = Guid.NewGuid().ToString(),
                        Folders = new List<string>()
                    };

                    worker.BackupChanges(guid, settings.ModGuid, _watchedChanges);
                    settings.Folders = _watchedChanges.Where(x => x.Value.Any()).Select(x => x.Key).ToList();
                    AddBackup(settings);
                    worker.ReportProgress(100, "Saving Complete");
                }
            }
            catch (Exception e)
            {
                worker.ReportProgress(100, $"Saving Failed: {e.Message}");
            }
        }
        #endregion

        #region Restore
        private static int _deletedFiles;
        private static int _restoredFiles;
        public static void RestoreBackup(this BackgroundWorker worker, Dictionary<string, string> paths, bool deleteExisting, string gameGuid, string backupGuid = null)
        {
            try
            {
                var zipName = $"{gameGuid}_Game.zip";
                if (!string.IsNullOrWhiteSpace(backupGuid)) zipName = $"{gameGuid}_{backupGuid}_Backup.zip";

                if (deleteExisting)
                {
                    worker.ReportProgress(0, "Deleting");
                    var allFiles = paths.SelectMany(x => Directory.GetFiles(x.Value));
                    var allDirs = paths.SelectMany(x => Directory.GetDirectories(x.Value));
                    _totalFiles = allFiles.Count() + allDirs.Count();
                    _deletedFiles = 0;
                    foreach (var file in allFiles)
                    {
                        var p = (int)((double)_deletedFiles / _totalFiles * 100);
                        if (p > 100) p = 100;
                        worker.ReportProgress(p, $"Deleting {file}");
                        File.Delete(file);
                        _deletedFiles++;
                    }
                    foreach (var dir in allDirs)
                    {
                        var p = (int)((double)_deletedFiles / _totalFiles * 100);
                        if (p > 100) p = 100;
                        worker.ReportProgress(p, $"Deleting {dir}");
                        Directory.Delete(dir, true);
                        _deletedFiles++;
                    }
                }

                using var zip = ZipFile.OpenRead(Path.Join(BackupPath, zipName));
                worker.ReportProgress(0, "Restoring");
                _totalFiles = zip.Entries.Count();
                _restoredFiles = 0;
                foreach (var path in paths)
                {
                    var files = zip.Entries.Where(x => x.FullName.StartsWith($"{path.Key}\\"));
                    foreach (var file in files)
                    {
                        var p = (int)((double)_restoredFiles / _totalFiles * 100);
                        if (p > 100) p = 100;
                        worker.ReportProgress(p, $"Restoring {file.FullName ?? ""}");

                        var pathArray = file.FullName.Split("\\").Skip(1).ToArray();
                        var basePath = path.Value;
                        for (int i = 0; i < pathArray.Length - 1; i++)
                        {
                            basePath = Path.Combine(basePath, pathArray[i]);
                            if (!Directory.Exists(basePath)) Directory.CreateDirectory(basePath);
                        }

                        file.ExtractToFile(Path.Combine(path.Value, file.FullName.Replace($"{path.Key}\\", "")), true);
                        _restoredFiles++;
                    }
                }
            }
            catch (Exception e)
            {
                worker.ReportProgress(100, $"Restoring Failed: {e.Message}");
            }
        }
        #endregion
    }
}
