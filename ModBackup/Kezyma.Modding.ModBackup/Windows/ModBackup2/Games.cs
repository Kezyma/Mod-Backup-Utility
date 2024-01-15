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
    public partial class Games : UserControl
    {
        public Games()
        {
            InitializeComponent();
        }
        public GameSettings SelectedGame;

        public void BindToGame(GameSettings game = null)
        {
            SelectedGame = game;
            btnDeleteGame.Enabled = game != null;
        }

        public void BuildGameList()
        {
            lstGameList.Items.Clear();
            ModBackupCore.GameList.OrderBy(x => x.Name).ToList().ForEach(x => lstGameList.Items.Add(x.Name));
        }

        private void btnAddGame_Click(object sender, EventArgs e) => ((ModBackup2)Parent).BindToGame(null);

        private void lstGameList_SelectedIndexChanged(object sender, EventArgs e) => ((ModBackup2)Parent).BindToGame(lstGameList.SelectedItem != null ? ModBackupCore.GameList.FirstOrDefault(x => x.Name == lstGameList.SelectedItem.ToString()) : null);
        private void btnDeleteGame_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Are you sure you want to delete {SelectedGame.Name}? This will remove all existing settings and backups.", "Are you sure?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ModBackupCore.DeleteGame(SelectedGame.Guid);
                BuildGameList();
                ((ModBackup2)Parent).BindToGame(null);
            }
        }
    }
}
