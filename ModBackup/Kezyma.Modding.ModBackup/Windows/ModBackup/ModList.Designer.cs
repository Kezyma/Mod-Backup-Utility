
namespace Kezyma.Modding.ModBackup.Windows
{
    partial class ModList
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstBackupList = new System.Windows.Forms.ListBox();
            this.btnNewBackup = new System.Windows.Forms.Button();
            this.btnDeleteBackup = new System.Windows.Forms.Button();
            this.btnRestoreBackup = new System.Windows.Forms.Button();
            this.btnGameList = new System.Windows.Forms.Button();
            this.txtBackupName = new System.Windows.Forms.TextBox();
            this.backgroundBackupper = new System.ComponentModel.BackgroundWorker();
            this.prgBackup = new System.Windows.Forms.ProgressBar();
            this.lblStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstBackupList
            // 
            this.lstBackupList.FormattingEnabled = true;
            this.lstBackupList.ItemHeight = 15;
            this.lstBackupList.Items.AddRange(new object[] {
            "No Backups"});
            this.lstBackupList.Location = new System.Drawing.Point(0, 32);
            this.lstBackupList.Name = "lstBackupList";
            this.lstBackupList.Size = new System.Drawing.Size(167, 139);
            this.lstBackupList.TabIndex = 0;
            this.lstBackupList.SelectedIndexChanged += new System.EventHandler(this.lstBackupList_SelectedIndexChanged);
            // 
            // btnNewBackup
            // 
            this.btnNewBackup.Enabled = false;
            this.btnNewBackup.Location = new System.Drawing.Point(173, 3);
            this.btnNewBackup.Name = "btnNewBackup";
            this.btnNewBackup.Size = new System.Drawing.Size(99, 23);
            this.btnNewBackup.TabIndex = 1;
            this.btnNewBackup.Text = "New Backup";
            this.btnNewBackup.UseVisualStyleBackColor = true;
            this.btnNewBackup.Click += new System.EventHandler(this.btnNewBackup_Click);
            // 
            // btnDeleteBackup
            // 
            this.btnDeleteBackup.Enabled = false;
            this.btnDeleteBackup.Location = new System.Drawing.Point(173, 32);
            this.btnDeleteBackup.Name = "btnDeleteBackup";
            this.btnDeleteBackup.Size = new System.Drawing.Size(99, 23);
            this.btnDeleteBackup.TabIndex = 2;
            this.btnDeleteBackup.Text = "Delete Backup";
            this.btnDeleteBackup.UseVisualStyleBackColor = true;
            this.btnDeleteBackup.Click += new System.EventHandler(this.btnDeleteBackup_Click);
            // 
            // btnRestoreBackup
            // 
            this.btnRestoreBackup.Enabled = false;
            this.btnRestoreBackup.Location = new System.Drawing.Point(173, 61);
            this.btnRestoreBackup.Name = "btnRestoreBackup";
            this.btnRestoreBackup.Size = new System.Drawing.Size(99, 23);
            this.btnRestoreBackup.TabIndex = 3;
            this.btnRestoreBackup.Text = "Restore Backup";
            this.btnRestoreBackup.UseVisualStyleBackColor = true;
            this.btnRestoreBackup.Click += new System.EventHandler(this.btnRestoreBackup_Click);
            // 
            // btnGameList
            // 
            this.btnGameList.Location = new System.Drawing.Point(173, 148);
            this.btnGameList.Name = "btnGameList";
            this.btnGameList.Size = new System.Drawing.Size(99, 23);
            this.btnGameList.TabIndex = 5;
            this.btnGameList.Text = "<- Game List";
            this.btnGameList.UseVisualStyleBackColor = true;
            this.btnGameList.Click += new System.EventHandler(this.btnGameList_Click);
            // 
            // txtBackupName
            // 
            this.txtBackupName.Location = new System.Drawing.Point(0, 3);
            this.txtBackupName.Name = "txtBackupName";
            this.txtBackupName.Size = new System.Drawing.Size(167, 23);
            this.txtBackupName.TabIndex = 6;
            this.txtBackupName.TextChanged += new System.EventHandler(this.txtBackupName_TextChanged);
            // 
            // backgroundBackupper
            // 
            this.backgroundBackupper.WorkerReportsProgress = true;
            this.backgroundBackupper.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundBackupper_DoWork);
            this.backgroundBackupper.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundBackupper_ProgressChanged);
            this.backgroundBackupper.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundBackupper_RunWorkerCompleted);
            // 
            // prgBackup
            // 
            this.prgBackup.Location = new System.Drawing.Point(0, 177);
            this.prgBackup.Name = "prgBackup";
            this.prgBackup.Size = new System.Drawing.Size(272, 23);
            this.prgBackup.TabIndex = 7;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(0, 203);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 15);
            this.lblStatus.TabIndex = 8;
            // 
            // ModList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly;
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.prgBackup);
            this.Controls.Add(this.txtBackupName);
            this.Controls.Add(this.btnGameList);
            this.Controls.Add(this.btnRestoreBackup);
            this.Controls.Add(this.btnDeleteBackup);
            this.Controls.Add(this.btnNewBackup);
            this.Controls.Add(this.lstBackupList);
            this.Name = "ModList";
            this.Size = new System.Drawing.Size(275, 218);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstBackupList;
        private System.Windows.Forms.Button btnNewBackup;
        private System.Windows.Forms.Button btnDeleteBackup;
        private System.Windows.Forms.Button btnRestoreBackup;
        private System.Windows.Forms.Button btnGameList;
        private System.Windows.Forms.TextBox txtBackupName;
        private System.ComponentModel.BackgroundWorker backgroundBackupper;
        private System.Windows.Forms.ProgressBar prgBackup;
        private System.Windows.Forms.Label lblStatus;
    }
}
