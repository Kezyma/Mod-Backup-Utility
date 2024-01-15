using Kezyma.Modding.ModBackup.Models;
using Kezyma.Modding.ModBackup.Windows;
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
using Kezyma.Modding.ModBackup.Utility;

namespace Kezyma.Modding.ModBackup
{
    public partial class ModBackup2 : Form
    {
        public ModBackup2()
        {
            InitializeComponent();
            games1.BuildGameList();
        }

        public GameSettings SelectedGame;



        public void BindToGame(GameSettings game = null)
        {
            SelectedGame = game;

            splSettings.Panel1.Controls.Clear();
            splSettings.Panel1.Controls.Add(new GamePanel(game));
            splSettings.Panel2.Controls.Clear();

            games1.BindToGame(game);
            backups1.BindToGame(game);
        }

        public void UpdateProgress(int percent, string text)
        {
            var state = 1;
            if (text.Contains(" Failed: ")) state = 2;
            else if (text.Contains("Recording")) state = 3;

            prgBarStatus.Value = percent;
            prgBarStatus.ProgressBar.SetState(state);

            lblBarStatus.Text = text;
        }

        private Dictionary<string, bool> _preProcessVisibility;
        public void InProgressDisable()
        {
            _preProcessVisibility = new Dictionary<string, bool>();
            foreach (var c in games1.Controls)
            {
                _preProcessVisibility.Add(((Control)c).Name, ((Control)c).Enabled);
                ((Control)c).Enabled = false;
            }
            foreach (var c in backups1.Controls)
            {
                _preProcessVisibility.Add(((Control)c).Name, ((Control)c).Enabled);
                ((Control)c).Enabled = false;
            }
            foreach (var c in splSettings.Panel1.Controls)
            {
                _preProcessVisibility.Add(((Control)c).Name, ((Control)c).Enabled);
                ((Control)c).Enabled = false;
            }
            foreach (var c in splSettings.Panel2.Controls)
            {
                _preProcessVisibility.Add(((Control)c).Name, ((Control)c).Enabled);
                ((Control)c).Enabled = false;
            }
        }

        public void InProgressEnable()
        {
            foreach (var c in games1.Controls) 
                if (_preProcessVisibility.ContainsKey(((Control)c).Name)) 
                    ((Control)c).Enabled = _preProcessVisibility[((Control)c).Name];
            foreach (var c in backups1.Controls) 
                if (_preProcessVisibility.ContainsKey(((Control)c).Name)) 
                    ((Control)c).Enabled = _preProcessVisibility[((Control)c).Name];
            foreach (var c in splSettings.Panel1.Controls) 
                if (_preProcessVisibility.ContainsKey(((Control)c).Name)) 
                    ((Control)c).Enabled = _preProcessVisibility[((Control)c).Name];
            foreach (var c in splSettings.Panel2.Controls) 
                if (_preProcessVisibility.ContainsKey(((Control)c).Name)) 
                    ((Control)c).Enabled = _preProcessVisibility[((Control)c).Name];
        }

        private void ModBackup2_Load(object sender, EventArgs e)
        {

        }
    }
}
