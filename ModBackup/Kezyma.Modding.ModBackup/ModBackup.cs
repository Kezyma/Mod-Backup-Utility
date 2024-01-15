using Kezyma.Modding.ModBackup.Windows;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kezyma.Modding.ModBackup
{
    public partial class ModBackup : Form
    {
        public ModBackup()
        {
            InitializeComponent();
            if (!Directory.Exists(BackupLocation)) Directory.CreateDirectory(BackupLocation);
        }

        private string BackupLocation => Path.Join(Directory.GetCurrentDirectory(), "Backups");
        private void ModBackup_Load(object sender, EventArgs e)
        {
            panel1.Controls.Add(new GameList());
        }
    }
}
