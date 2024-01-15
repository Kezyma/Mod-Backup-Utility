using Kezyma.Modding.ModBackup.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kezyma.Modding.ModBackup.Windows
{
    public partial class ModList : UserControl
    {
        public ModList(string guid)
        {
            InitializeComponent();
            _gameGuid = guid;
            BuildBackupList();
        }

        private string _gameGuid;
        private string _backupGuid;
        private Dictionary<string, string> _backupList => ModBackupCore.BackupList.ContainsKey(_gameGuid) ? ModBackupCore.BackupList[_gameGuid].ToDictionary(x => x.Name, x => x.ModGuid) : new Dictionary<string, string>();
        private void btnDeleteBackup_Click(object sender, EventArgs e)
        {
            ModBackupCore.DeleteBackup(ModBackupCore.BackupList[_gameGuid].FirstOrDefault(x => x.Name == lstBackupList.SelectedItem.ToString()).ModGuid);
            BuildBackupList();
        }
        private void btnNewBackup_Click(object sender, EventArgs e)
        {
            backgroundBackupper.RunWorkerAsync();
            btnNewBackup.Enabled = false;
            btnGameList.Enabled = false;
        }
        private void btnRestoreBackup_Click(object sender, EventArgs e)
        {
            var p = (Panel)Parent;
            p.Controls.Clear();
            p.Controls.Add(new RestoreBackup(_gameGuid, _backupGuid));
        }
        private void lstBackupList_SelectedIndexChanged(object sender, EventArgs e)
        {
            var r = lstBackupList.SelectedItem != null && lstBackupList.SelectedItem.ToString().Length > 0;
            if (r) _backupGuid = _backupList[lstBackupList.SelectedItem.ToString()];
            btnRestoreBackup.Enabled = r;
            btnDeleteBackup.Enabled = r;
        }
        private void BuildBackupList()
        {
            lstBackupList.Items.Clear();
            _backupList?.Keys.OrderBy(x => x).ToList().ForEach(x => lstBackupList.Items.Add(x));
        }
        private void btnGameList_Click(object sender, EventArgs e)
        {
            var p = (Panel)Parent;
            p.Controls.Clear();
            p.Controls.Add(new GameList());
        }
        private void txtBackupName_TextChanged(object sender, EventArgs e)
        {
            btnNewBackup.Enabled = !string.IsNullOrWhiteSpace(txtBackupName.Text) && !_backupList.ContainsKey(txtBackupName.Text);
        }
        private void backgroundBackupper_DoWork(object sender, DoWorkEventArgs e)
        {
            backgroundBackupper.ScanChanges(_gameGuid, txtBackupName.Text);
        }
        private void backgroundBackupper_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            lblStatus.Text = e.UserState.ToString();
            prgBackup.Value = e.ProgressPercentage;
        }
        private void backgroundBackupper_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            txtBackupName.Text = string.Empty;
            btnGameList.Enabled = true;
            BuildBackupList();
        }
    }
}
