using Kezyma.Modding.ModBackup.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kezyma.Modding.ModBackup.Windows
{
    public partial class GamePanel : UserControl
    {
        public GamePanel(GameSettings settings = null)
        {
            InitializeComponent();
            BindToGame(settings);
        }

        private void GamePanel_Load(object sender, EventArgs e)
        {
            _mb2 = (ModBackup2)ParentForm;
        }

        private GameSettings _settings;
        private Dictionary<string, string> _folderPaths;
        private ModBackup2 _mb2;

        private void BindToGame(GameSettings settings = null)
        {
            _settings = settings;
            _folderPaths = settings != null ? settings.Folders.ToDictionary(x => x.Name, x => x.Path) : new Dictionary<string, string>();
            txtGameName.Text = settings?.Name ?? "";
            lblGuidValue.Text = settings?.Guid ?? "...";
            chkBackupGame.Checked = settings == null || !ModBackupCore.GameHasBackup(_settings.Guid);
            UpdateInputState();
            BindFolders();
        }

        private void BindFolders()
        {
            lblGameDirPath.Text = _folderPaths.ContainsKey(ModBackupCore.GameDir) ? _folderPaths[ModBackupCore.GameDir] : "...";
            lblDocsDirPath.Text = _folderPaths.ContainsKey(ModBackupCore.DocsDir) ? _folderPaths[ModBackupCore.DocsDir] : "...";
            lblToolsDirPath.Text = _folderPaths.ContainsKey(ModBackupCore.ToolsDir) ? _folderPaths[ModBackupCore.ToolsDir] : "...";
            BindCustomList();
        }

        private void UpdateInputState()
        {
            btnSaveSettings.Enabled = _settings != null;
            btnScanGame.Enabled = _folderPaths.ContainsKey(ModBackupCore.GameDir) && !string.IsNullOrWhiteSpace(txtGameName.Text) && (_settings != null || !ModBackupCore.GameList.Any(x => x.Name == txtGameName.Name));
            btnCustomDir.Enabled = !string.IsNullOrWhiteSpace(txtCustomDirName.Text) && !_folderPaths.ContainsKey(txtCustomDirName.Text) && !new List<string> { ModBackupCore.GameDir, ModBackupCore.DocsDir, ModBackupCore.ToolsDir }.Contains(txtCustomDirName.Text);
            btnRemoveDir.Enabled = lstCustomDir.SelectedItem != null && _folderPaths.ContainsKey(lstCustomDir.SelectedItem.ToString().Split(':')[0]);
        }

        private void BindCustomList()
        {
            lstCustomDir.Items.Clear();
            _folderPaths.Where(x => !new List<string> { ModBackupCore.GameDir, ModBackupCore.DocsDir, ModBackupCore.ToolsDir }.Contains(x.Key)).ToList().ForEach(x => lstCustomDir.Items.Add($"{x.Key}: {x.Value}"));
        }

        private void txtGameName_TextChanged(object sender, EventArgs e) => UpdateInputState();
        private void txtCustomDirName_TextChanged(object sender, EventArgs e) => UpdateInputState();
        private void lstCustomDir_SelectedIndexChanged(object sender, EventArgs e) => UpdateInputState();

        private void btnGameDir_Click(object sender, EventArgs e)
        {
            _folderPaths.SelectFolder(ModBackupCore.GameDir, lblGameDirPath);
            UpdateInputState();
        }

        private void btnDocsDir_Click(object sender, EventArgs e) => _folderPaths.SelectFolder(ModBackupCore.DocsDir, lblDocsDirPath);

        private void btnToolsDir_Click(object sender, EventArgs e) => _folderPaths.SelectFolder(ModBackupCore.ToolsDir, lblToolsDirPath);

        private void btnCustomDir_Click(object sender, EventArgs e)
        {
            _folderPaths.SelectFolder(txtCustomDirName.Text);
            BindCustomList();
            txtCustomDirName.Text = string.Empty;
            btnCustomDir.Enabled = false;
        }

        private void btnRemoveDir_Click(object sender, EventArgs e)
        {
            _folderPaths.Remove(lstCustomDir.SelectedItem.ToString().Split(':')[0]);
            BindCustomList();
            UpdateInputState();
        }

        private void btnSaveSettings_Click(object sender, EventArgs e)
        {
            _settings.Name = txtGameName.Text;
            _folderPaths.ToList().ForEach(x => 
            {
                if (_settings.Folders.Any(f => f.Name == x.Key)) _settings.Folders.First(f => f.Name == x.Key).Path = x.Value;
                else _settings.Folders.Add(new FolderDefinition { Name = x.Key, Path = x.Value, Files = new List<FileDefinition>() });
            });
            _settings.Folders.RemoveAll(x => !_folderPaths.ContainsKey(x.Name));
            ModBackupCore.AddGame(_settings);
        }

        private void btnScanGame_Click(object sender, EventArgs e)
        {
            _mb2.InProgressDisable();
            bgwScanGame.RunWorkerAsync();
        }

        private void bgwScanGame_DoWork(object sender, DoWorkEventArgs e)
        {
            bgwScanGame.ReportProgress(0, "Starting");
            var guid = _settings != null ? _settings.Guid : Guid.NewGuid().ToString();
            bgwScanGame.ScanGame(guid, txtGameName.Text, _folderPaths);
            if (chkBackupGame.Checked)
            {
                bgwScanGame.ReportProgress(0, "Backing Up");
                bgwScanGame.BackupGame(guid);
            }
            bgwScanGame.ReportProgress(100, "Scan Complete");
        }

        private void bgwScanGame_ProgressChanged(object sender, ProgressChangedEventArgs e) => _mb2.UpdateProgress(e.ProgressPercentage, e.UserState.ToString());

        private void bgwScanGame_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e) 
        {
            _mb2.games1.BuildGameList();
            _mb2.BindToGame(ModBackupCore.GameList.FirstOrDefault(x => x.Name == txtGameName.Text));
            _mb2.InProgressEnable();
        }
    }
}
