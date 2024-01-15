using Kezyma.Modding.ModBackup.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kezyma.Modding.ModBackup.Windows
{
    public partial class RestoreBackup : UserControl
    {
        public RestoreBackup(string gameGuid, string backupGuid = null)
        {
            InitializeComponent();
            _gameGuid = gameGuid;
            _backupGuid = backupGuid;
            lblGame.Text = _gameSettings.Name;
            if (!string.IsNullOrWhiteSpace(_backupGuid))
            {
                lblGame.Text += $" ({_backupSettings.Name})";
                btnGameList.Text = "<- Backup List";
            }
            else 
            { 
                chkDeleteExisting.Checked = true; 
            }
            _folderPaths = _gameSettings.Folders.ToDictionary(x => x.Name, x => x.Path);
            CreateFolderInputs();
        }

        private string _gameGuid;
        private string _backupGuid;

        private Dictionary<string, string> _folderPaths;
        private GameSettings _gameSettings => ModBackupCore.GameList.FirstOrDefault(x => x.Guid == _gameGuid);
        private ModSettings _backupSettings => ModBackupCore.BackupList.ContainsKey(_gameGuid) ? ModBackupCore.BackupList[_gameGuid].FirstOrDefault(x => x.ModGuid == _backupGuid) : null;
        private List<string> _folders => _gameSettings.Folders.Select(x => x.Name).ToList();

        private void CreateFolderInputs()
        {
            int i = 1;
            foreach (var folder in _folders)
            {
                Controls.Add(GetFolderLabel(folder, i));
                Controls.Add(GetSelectButton(folder, i));
                Controls.Add(GetPathLabel(folder, i));
                i++;
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            using var fs = new FolderBrowserDialog();
            var res = fs.ShowDialog();
            if (res == DialogResult.OK)
            {
                var folder = new string(((Button)sender).Name.Skip(3).ToArray());
                if (_folderPaths.ContainsKey(folder)) _folderPaths[folder] = fs.SelectedPath;
                else _folderPaths.Add(folder, fs.SelectedPath);
                var lbl = (Label)Controls.Find($"lbl{folder}Folder", true).FirstOrDefault();
                lbl.Text = fs.SelectedPath;
            }
        }
        private Label GetFolderLabel(string name, int row)
        {
            var lbl = new Label
            {
                AutoSize = true,
                Location = new Point(1, 100 + row * 23),
                Name = $"lbl{name}",
                Size = new Size(41, 15),
                TabIndex = 0,
                Text = $"{name}:"
            };
            return lbl;
        }
        private Button GetSelectButton(string name, int row)
        {
            var btn = new Button
            {
                Text = "Select",
                Location = new Point(45, 97 + row * 23),
                Name = $"btn{name}",
                Size = new Size(75, 23),
                TabIndex = 3,
                UseVisualStyleBackColor = true
            };
            btn.Click += new EventHandler(btnSelect_Click);
            return btn;
        }
        private Label GetPathLabel(string name, int row)
        {
            var lbl = new Label
            {
                AutoSize = true,
                Location = new Point(120, 100 + row * 23),
                Name = $"lbl{name}Folder",
                Size = new Size(16, 15),
                TabIndex = 15,
                Text = _folderPaths[name]
            };
            return lbl;
        }

        private void btnGameList_Click(object sender, EventArgs e)
        {
            var p = (Panel)Parent;
            p.Controls.Clear();
            if (!string.IsNullOrWhiteSpace(_backupGuid)) p.Controls.Add(new ModList(_gameGuid));
            else p.Controls.Add(new GameList());
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            btnRestore.Enabled = false;
            btnGameList.Enabled = false;
            backgroundRestorer.RunWorkerAsync();
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            backgroundRestorer.RestoreBackup(_folderPaths, chkDeleteExisting.Checked, _gameGuid, _backupGuid);
        }

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            lblStatus.Text = e.UserState.ToString();
            prgRestore.Value = e.ProgressPercentage;
        }

        private void backgroundRestorer_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            prgRestore.Value = 100;
            lblStatus.Text = "Restore Complete";
            btnRestore.Enabled = true;
            btnGameList.Enabled = true;
        }
    }
}