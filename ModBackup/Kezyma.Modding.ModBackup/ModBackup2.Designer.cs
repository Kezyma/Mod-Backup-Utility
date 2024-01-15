
using Kezyma.Modding.ModBackup.Windows;

namespace Kezyma.Modding.ModBackup
{
    partial class ModBackup2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.strStatus = new System.Windows.Forms.StatusStrip();
            this.prgBarStatus = new System.Windows.Forms.ToolStripProgressBar();
            this.lblBarStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.games1 = new Kezyma.Modding.ModBackup.Windows.Games();
            this.backups1 = new Kezyma.Modding.ModBackup.Windows.Backups();
            this.splSettings = new System.Windows.Forms.SplitContainer();
            this.strStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splSettings)).BeginInit();
            this.splSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // strStatus
            // 
            this.strStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prgBarStatus,
            this.lblBarStatus});
            this.strStatus.Location = new System.Drawing.Point(0, 552);
            this.strStatus.Name = "strStatus";
            this.strStatus.Size = new System.Drawing.Size(1088, 22);
            this.strStatus.TabIndex = 16;
            this.strStatus.Text = "...";
            // 
            // prgBarStatus
            // 
            this.prgBarStatus.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.prgBarStatus.Name = "prgBarStatus";
            this.prgBarStatus.Size = new System.Drawing.Size(100, 16);
            // 
            // lblBarStatus
            // 
            this.lblBarStatus.Name = "lblBarStatus";
            this.lblBarStatus.Size = new System.Drawing.Size(16, 17);
            this.lblBarStatus.Text = "...";
            // 
            // games1
            // 
            this.games1.AutoSize = true;
            this.games1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.games1.Dock = System.Windows.Forms.DockStyle.Left;
            this.games1.Location = new System.Drawing.Point(0, 2);
            this.games1.Name = "games1";
            this.games1.Size = new System.Drawing.Size(161, 550);
            this.games1.TabIndex = 0;
            // 
            // backups1
            // 
            this.backups1.AutoSize = true;
            this.backups1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.backups1.Dock = System.Windows.Forms.DockStyle.Left;
            this.backups1.Location = new System.Drawing.Point(161, 2);
            this.backups1.Name = "backups1";
            this.backups1.Size = new System.Drawing.Size(158, 550);
            this.backups1.TabIndex = 17;
            // 
            // splSettings
            // 
            this.splSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splSettings.Location = new System.Drawing.Point(319, 2);
            this.splSettings.Name = "splSettings";
            this.splSettings.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splSettings.Panel1
            // 
            this.splSettings.Panel1.AutoScroll = true;
            // 
            // splSettings.Panel2
            // 
            this.splSettings.Panel2.AutoScroll = true;
            this.splSettings.Size = new System.Drawing.Size(769, 550);
            this.splSettings.SplitterDistance = 273;
            this.splSettings.TabIndex = 18;
            // 
            // ModBackup2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 574);
            this.Controls.Add(this.splSettings);
            this.Controls.Add(this.backups1);
            this.Controls.Add(this.games1);
            this.Controls.Add(this.strStatus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ModBackup2";
            this.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.Text = "Kezyma\'s Mod Backup Utility";
            this.Load += new System.EventHandler(this.ModBackup2_Load);
            this.strStatus.ResumeLayout(false);
            this.strStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splSettings)).EndInit();
            this.splSettings.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip strStatus;
        public Games games1;
        public Backups backups1;
        public System.Windows.Forms.SplitContainer splSettings;
        private System.Windows.Forms.ToolStripProgressBar prgBarStatus;
        public System.Windows.Forms.ToolStripStatusLabel lblBarStatus;
    }
}