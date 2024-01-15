using Kezyma.Modding.ModBackup.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kezyma.Modding.ModBackup.Windows
{
    public partial class Backups : UserControl
    {
        public Backups()
        {
            InitializeComponent();
        }

        private void Backups_Load(object sender, EventArgs e)
        {
            _mb2 = (ModBackup2)ParentForm;
        }

        public GameSettings SelectedGame;
        private ModBackup2 _mb2;
        public void BindToGame(GameSettings game = null)
        {
            SelectedGame = game;

            txtBackupName.Text = "";
            txtBackupName.Enabled = game != null;
            btnAddBackup.Enabled = false;
            btnRecord.Enabled = false;
            btnSaveRecord.Enabled = false;
            btnDeleteBackup.Enabled = false;

            BuildBackupList();
        }

        public void BuildBackupList()
        {
            lstBackupList.Items.Clear();
            if (SelectedGame != null)
            {
                if (ModBackupCore.GameHasBackup(SelectedGame.Guid))
                    lstBackupList.Items.Add("Base Game");

                if (ModBackupCore.BackupList.ContainsKey(SelectedGame.Guid))
                    ModBackupCore.BackupList[SelectedGame.Guid].OrderBy(x => x.BackupDate).ToList().ForEach(x => lstBackupList.Items.Add(x.Name));

                if (lstBackupList.Items.Count > 0) lstBackupList.SelectedIndex = 0;
                else btnBrowseFiles.Enabled = false;
            }
            else btnBrowseFiles.Enabled = false;

            lstBackupList.Enabled = lstBackupList.Items.Count > 0;
        }

        private void txtBackupName_TextChanged(object sender, EventArgs e)
        {
            btnAddBackup.Enabled = SelectedGame != null && !string.IsNullOrWhiteSpace(txtBackupName.Text) && (!ModBackupCore.BackupList.ContainsKey(SelectedGame.Guid) || !ModBackupCore.BackupList[SelectedGame.Guid].Any(x => x.Name == txtBackupName.Name));
            btnRecord.Enabled = btnAddBackup.Enabled;
        }

        private void btnAddBackup_Click(object sender, EventArgs e)
        {
            _mb2.InProgressDisable();
            bgwScanChanges.RunWorkerAsync();
        }

        private void btnDeleteBackup_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Are you sure you want to delete {SelectedGame.Name} {lstBackupList.SelectedItem}? This cannot be undone.", "Are you sure?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (lstBackupList.SelectedItem.ToString() == "Base Game") ModBackupCore.DeleteGameBackup(SelectedGame.Guid);
                else ModBackupCore.DeleteBackup(ModBackupCore.BackupList[SelectedGame.Guid].FirstOrDefault(x => x.Name == lstBackupList.SelectedItem.ToString()).ModGuid);
                btnDeleteBackup.Enabled = false;
                BuildBackupList();
            }
        }

        private void lstBackupList_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnDeleteBackup.Enabled = lstBackupList.SelectedItem != null;
            btnBrowseFiles.Enabled = lstBackupList.SelectedItem != null;
            _mb2.splSettings.Panel2.Controls.Clear();
            if (lstBackupList.SelectedItem != null)
                _mb2.splSettings.Panel2.Controls.Add(new RestorePanel(SelectedGame.Guid, (lstBackupList.SelectedItem.ToString() != "Base Game") ? ModBackupCore.BackupList[SelectedGame.Guid].FirstOrDefault(x => x.Name == lstBackupList.SelectedItem.ToString()).ModGuid : null));
        }

        private void btnBrowseFiles_Click(object sender, EventArgs e)
        {
            if (lstBackupList.SelectedItem != null)
            {
                var file = $"{SelectedGame.Guid}_Game.zip";
                if (lstBackupList.SelectedItem.ToString() != "Base Game")
                {
                    file = $"{SelectedGame.Guid}_{ModBackupCore.BackupList[SelectedGame.Guid].FirstOrDefault(x => x.Name == lstBackupList.SelectedItem.ToString()).ModGuid}_Backup.zip";
                }
                new Process { StartInfo = new ProcessStartInfo(Path.Join(ModBackupCore.BackupPath, file)) { UseShellExecute = true } }.Start();
            }
        }

        private void bgwScanChanges_DoWork(object sender, DoWorkEventArgs e)
        {
            bgwScanChanges.ScanChanges(SelectedGame.Guid, txtBackupName.Text);
        }

        private void bgwScanChanges_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            _mb2.UpdateProgress(e.ProgressPercentage, e.UserState.ToString());
        }

        private void bgwScanChanges_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            txtBackupName.Text = "";
            BuildBackupList();
            _mb2.InProgressEnable();
        }

        private void btnRecord_Click(object sender, EventArgs e)
        {
            _mb2.InProgressDisable();
            _mb2.UpdateProgress(100, "Recording ...");
            try
            {
                ModBackupCore.StartRecord(SelectedGame.Guid);
                btnSaveRecord.Enabled = true;
            }
            catch (Exception ex)
            {
                _mb2.UpdateProgress(100, $"Recording Failed: {ex.Message}");
                _mb2.InProgressEnable();
            }
        }

        private void btnSaveRecord_Click(object sender, EventArgs e)
        {
            btnSaveRecord.Enabled = false;
            bgwRecordChanges.RunWorkerAsync();
        }

        private void bgwRecordChanges_DoWork(object sender, DoWorkEventArgs e)
        {
            bgwRecordChanges.SaveRecordedChanges(SelectedGame.Guid, txtBackupName.Text);
        }

        private void bgwRecordChanges_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            _mb2.UpdateProgress(e.ProgressPercentage, e.UserState.ToString());
        }

        private void bgwRecordChanges_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            txtBackupName.Text = "";
            BuildBackupList();
            _mb2.InProgressEnable();
        }
    }
}
