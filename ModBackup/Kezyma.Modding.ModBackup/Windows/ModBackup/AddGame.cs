using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.IO.Compression;
using System.IO;
using System.Security.Cryptography;
using Kezyma.Modding.ModBackup.Models;
using System.Linq;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace Kezyma.Modding.ModBackup.Windows
{
    public partial class AddGame : UserControl
    {
        public AddGame()
        {
            InitializeComponent();
            _folderPaths = new Dictionary<string, string>();
        }
        public AddGame(string guid)
        {
            InitializeComponent();
            _gameGuid = guid;
            var settings = ModBackupCore.GameList.FirstOrDefault(x => x.Guid == _gameGuid);
            _folderPaths = settings.Folders.ToDictionary(x => x.Name, x => x.Path);
            btnScanGame.Enabled = true;
            if (_folderPaths.ContainsKey(ModBackupCore.GameDir)) lblGameDir.Text = _folderPaths[ModBackupCore.GameDir];
            if (_folderPaths.ContainsKey(ModBackupCore.DocsDir)) lblDocsDir.Text = _folderPaths[ModBackupCore.DocsDir];
            if (_folderPaths.ContainsKey(ModBackupCore.ToolsDir)) lblToolsDir.Text = _folderPaths[ModBackupCore.ToolsDir];
            if (_folderPaths.Keys.Any(x => x != ModBackupCore.GameDir && x != ModBackupCore.DocsDir && x != ModBackupCore.ToolsDir)) BindCustomList();
            txtGame.Text = settings.Name;
            btnSaveChanges.Visible = true;
        }

        private Dictionary<string, string> _folderPaths { get; set; }

        private string _gameGuid;
        private void btnGameDir_Click(object sender, EventArgs e)
        {
            _folderPaths.SelectFolder(ModBackupCore.GameDir, lblGameDir);
            if (!string.IsNullOrWhiteSpace(txtGame.Text)) btnScanGame.Enabled = true;
        }
        private void btnDocDir_Click(object sender, EventArgs e) => _folderPaths.SelectFolder(ModBackupCore.DocsDir, lblDocsDir);
        private void btnToolDir_Click(object sender, EventArgs e) => _folderPaths.SelectFolder(ModBackupCore.ToolsDir, lblToolsDir);
        private void btnCustomDir_Click(object sender, EventArgs e)
        {
            _folderPaths.SelectFolder(txtCustomDir.Text);
            BindCustomList();
            txtCustomDir.Text = string.Empty;
            btnCustomDir.Enabled = false;
        }
        private void txtCustomDir_TextChanged(object sender, EventArgs e) => btnCustomDir.Enabled = !string.IsNullOrWhiteSpace(txtCustomDir.Text) && !_folderPaths.ContainsKey(txtCustomDir.Text);
        private void btnRmCustom_Click(object sender, EventArgs e)
        {
            var itm = lstCustomDir.SelectedItem.ToString().Split(":")[0];
            _folderPaths.Remove(itm);
            BindCustomList();
            btnRmCustom.Enabled = false;
        }
        private void lstCustomDir_SelectedIndexChanged(object sender, EventArgs e) => btnRmCustom.Enabled = lstCustomDir.SelectedItem != null;
        private void BindCustomList()
        {
            lstCustomDir.Items.Clear();
            foreach (var dir in _folderPaths)
                if (dir.Key != ModBackupCore.ToolsDir && dir.Key != ModBackupCore.DocsDir && dir.Key != ModBackupCore.GameDir)
                    lstCustomDir.Items.Add($"{dir.Key}: {dir.Value}");
        }
        private void btnScanGame_Click(object sender, EventArgs e)
        {
            btnGameList.Enabled = false;
            backgroundBackupper.RunWorkerAsync();
        }
        
        private void btnGameList_Click(object sender, EventArgs e)
        {
            var p = (Panel)Parent;
            p.Controls.Clear();
            p.Controls.Add(new GameList());
        }
        private void backgroundBackupper_DoWork(object sender, DoWorkEventArgs e)
        {
            backgroundBackupper.ReportProgress(0, "Starting");
            if (string.IsNullOrWhiteSpace(_gameGuid)) _gameGuid = Guid.NewGuid().ToString();
            backgroundBackupper.ScanGame(_gameGuid, txtGame.Text, _folderPaths);
            if (chkBackupGame.Checked)
            {
                backgroundBackupper.ReportProgress(0, "Backing Up");
                backgroundBackupper.BackupGame(_gameGuid);
            }
            backgroundBackupper.ReportProgress(100, "Scan Complete");
        }

        private void backgroundBackupper_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            prgScanGame.Value = e.ProgressPercentage;
            lblStatusText.Text = e.UserState.ToString();
        }
        private void backgroundBackupper_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            btnGameList.Enabled = true;
            ModBackupCore.ReloadGameList();
        }
        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            var settings = ModBackupCore.GameList.FirstOrDefault(x => x.Guid == _gameGuid);
            settings.Name = txtGame.Text;
            foreach (var path in _folderPaths)
            {
                var fol = settings.Folders.FirstOrDefault(x => x.Name == path.Key);
                if (fol != null) fol.Path = path.Value;
                else settings.Folders.Add(new FolderDefinition { Name = path.Key, Path = path.Value });
            }
            settings.Folders.RemoveAll(x => !_folderPaths.ContainsKey(x.Name));
            ModBackupCore.AddGame(settings);
        }

        private void txtGame_TextChanged(object sender, EventArgs e) => btnScanGame.Enabled = !string.IsNullOrWhiteSpace(txtGame.Text) && _folderPaths.ContainsKey(ModBackupCore.GameDir);
    }
}
