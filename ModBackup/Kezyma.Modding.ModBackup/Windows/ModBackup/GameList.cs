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
    public partial class GameList : UserControl
    {
        public GameList()
        {
            InitializeComponent();
            RebuildGameList();
        }

        private GameSettings SelectedGame => ModBackupCore.GameList.FirstOrDefault(x => x.Name == lstGameList.SelectedItem.ToString());

        private void btnDeleteGame_Click(object sender, EventArgs e)
        {
            ModBackupCore.DeleteGame(SelectedGame.Guid);
            RebuildGameList();
        }

        private void btnAddGame_Click(object sender, EventArgs e)
        {
            var p = (Panel)Parent;
            p.Controls.Clear();
            p.Controls.Add(new AddGame());
        }

        private void btnUpdateGame_Click(object sender, EventArgs e)
        {
            var p = (Panel)Parent;
            p.Controls.Clear();
            p.Controls.Add(new AddGame(SelectedGame.Guid));
        }

        private void btnRestoreGame_Click(object sender, EventArgs e)
        {
            var p = (Panel)Parent;
            p.Controls.Clear();
            p.Controls.Add(new RestoreBackup(SelectedGame.Guid));
        }

        private void btnManageMods_Click(object sender, EventArgs e)
        {
            var p = (Panel)Parent;
            p.Controls.Clear();
            p.Controls.Add(new ModList(SelectedGame.Guid));
        }

        private void lstGameList_SelectedIndexChanged(object sender, EventArgs e)
        {
            var r = lstGameList.SelectedItem != null && 
                lstGameList.SelectedItem.ToString().Length > 0 && 
                ModBackupCore.GameList.Any(x => x.Name == lstGameList.SelectedItem.ToString());
            btnUpdateGame.Enabled = r;
            btnDeleteGame.Enabled = r;
            btnRestoreGame.Enabled = r && ModBackupCore.GameHasBackup(ModBackupCore.GameList.FirstOrDefault(x => x.Name == lstGameList.SelectedItem.ToString()).Guid);
            btnManageMods.Enabled = r;
        }

        private void RebuildGameList()
        {
            lstGameList.Items.Clear();
            ModBackupCore.GameList.Select(x => x.Name).OrderBy(x => x).ToList().ForEach(x => lstGameList.Items.Add(x));
        }
    }
}
