
namespace Kezyma.Modding.ModBackup.Windows
{
    partial class GamePanel
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
            this.lblGameName = new System.Windows.Forms.Label();
            this.lblGameGuid = new System.Windows.Forms.Label();
            this.lblGameDir = new System.Windows.Forms.Label();
            this.lblDocsDir = new System.Windows.Forms.Label();
            this.lblToolsDir = new System.Windows.Forms.Label();
            this.lblCustomDir = new System.Windows.Forms.Label();
            this.txtGameName = new System.Windows.Forms.TextBox();
            this.btnDocsDir = new System.Windows.Forms.Button();
            this.btnToolsDir = new System.Windows.Forms.Button();
            this.btnGameDir = new System.Windows.Forms.Button();
            this.btnCustomDir = new System.Windows.Forms.Button();
            this.lblGuidValue = new System.Windows.Forms.Label();
            this.lblGameDirPath = new System.Windows.Forms.Label();
            this.lblDocsDirPath = new System.Windows.Forms.Label();
            this.lblToolsDirPath = new System.Windows.Forms.Label();
            this.txtCustomDirName = new System.Windows.Forms.TextBox();
            this.lstCustomDir = new System.Windows.Forms.ListBox();
            this.btnRemoveDir = new System.Windows.Forms.Button();
            this.btnSaveSettings = new System.Windows.Forms.Button();
            this.btnScanGame = new System.Windows.Forms.Button();
            this.chkBackupGame = new System.Windows.Forms.CheckBox();
            this.bgwScanGame = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // lblGameName
            // 
            this.lblGameName.AutoSize = true;
            this.lblGameName.Location = new System.Drawing.Point(0, 3);
            this.lblGameName.Name = "lblGameName";
            this.lblGameName.Size = new System.Drawing.Size(41, 15);
            this.lblGameName.TabIndex = 0;
            this.lblGameName.Text = "Game:";
            // 
            // lblGameGuid
            // 
            this.lblGameGuid.AutoSize = true;
            this.lblGameGuid.Location = new System.Drawing.Point(0, 32);
            this.lblGameGuid.Name = "lblGameGuid";
            this.lblGameGuid.Size = new System.Drawing.Size(35, 15);
            this.lblGameGuid.TabIndex = 1;
            this.lblGameGuid.Text = "Guid:";
            // 
            // lblGameDir
            // 
            this.lblGameDir.AutoSize = true;
            this.lblGameDir.Location = new System.Drawing.Point(0, 62);
            this.lblGameDir.Name = "lblGameDir";
            this.lblGameDir.Size = new System.Drawing.Size(92, 15);
            this.lblGameDir.TabIndex = 2;
            this.lblGameDir.Text = "Game Directory:";
            // 
            // lblDocsDir
            // 
            this.lblDocsDir.AutoSize = true;
            this.lblDocsDir.Location = new System.Drawing.Point(0, 91);
            this.lblDocsDir.Name = "lblDocsDir";
            this.lblDocsDir.Size = new System.Drawing.Size(87, 15);
            this.lblDocsDir.TabIndex = 3;
            this.lblDocsDir.Text = "Docs Directory:";
            // 
            // lblToolsDir
            // 
            this.lblToolsDir.AutoSize = true;
            this.lblToolsDir.Location = new System.Drawing.Point(-1, 120);
            this.lblToolsDir.Name = "lblToolsDir";
            this.lblToolsDir.Size = new System.Drawing.Size(88, 15);
            this.lblToolsDir.TabIndex = 4;
            this.lblToolsDir.Text = "Tools Directory:";
            // 
            // lblCustomDir
            // 
            this.lblCustomDir.AutoSize = true;
            this.lblCustomDir.Location = new System.Drawing.Point(-1, 149);
            this.lblCustomDir.Name = "lblCustomDir";
            this.lblCustomDir.Size = new System.Drawing.Size(103, 15);
            this.lblCustomDir.TabIndex = 5;
            this.lblCustomDir.Text = "Custom Directory:";
            // 
            // txtGameName
            // 
            this.txtGameName.Location = new System.Drawing.Point(47, 0);
            this.txtGameName.Name = "txtGameName";
            this.txtGameName.Size = new System.Drawing.Size(511, 23);
            this.txtGameName.TabIndex = 6;
            this.txtGameName.TextChanged += new System.EventHandler(this.txtGameName_TextChanged);
            // 
            // btnDocsDir
            // 
            this.btnDocsDir.Location = new System.Drawing.Point(108, 87);
            this.btnDocsDir.Name = "btnDocsDir";
            this.btnDocsDir.Size = new System.Drawing.Size(75, 23);
            this.btnDocsDir.TabIndex = 9;
            this.btnDocsDir.Text = "Select";
            this.btnDocsDir.UseVisualStyleBackColor = true;
            this.btnDocsDir.Click += new System.EventHandler(this.btnDocsDir_Click);
            // 
            // btnToolsDir
            // 
            this.btnToolsDir.Location = new System.Drawing.Point(108, 116);
            this.btnToolsDir.Name = "btnToolsDir";
            this.btnToolsDir.Size = new System.Drawing.Size(75, 23);
            this.btnToolsDir.TabIndex = 10;
            this.btnToolsDir.Text = "Select";
            this.btnToolsDir.UseVisualStyleBackColor = true;
            this.btnToolsDir.Click += new System.EventHandler(this.btnToolsDir_Click);
            // 
            // btnGameDir
            // 
            this.btnGameDir.Location = new System.Drawing.Point(108, 58);
            this.btnGameDir.Name = "btnGameDir";
            this.btnGameDir.Size = new System.Drawing.Size(75, 23);
            this.btnGameDir.TabIndex = 11;
            this.btnGameDir.Text = "Select";
            this.btnGameDir.UseVisualStyleBackColor = true;
            this.btnGameDir.Click += new System.EventHandler(this.btnGameDir_Click);
            // 
            // btnCustomDir
            // 
            this.btnCustomDir.Enabled = false;
            this.btnCustomDir.Location = new System.Drawing.Point(108, 145);
            this.btnCustomDir.Name = "btnCustomDir";
            this.btnCustomDir.Size = new System.Drawing.Size(75, 23);
            this.btnCustomDir.TabIndex = 12;
            this.btnCustomDir.Text = "Select";
            this.btnCustomDir.UseVisualStyleBackColor = true;
            this.btnCustomDir.Click += new System.EventHandler(this.btnCustomDir_Click);
            // 
            // lblGuidValue
            // 
            this.lblGuidValue.AutoSize = true;
            this.lblGuidValue.Location = new System.Drawing.Point(47, 32);
            this.lblGuidValue.Name = "lblGuidValue";
            this.lblGuidValue.Size = new System.Drawing.Size(16, 15);
            this.lblGuidValue.TabIndex = 13;
            this.lblGuidValue.Text = "...";
            // 
            // lblGameDirPath
            // 
            this.lblGameDirPath.AutoSize = true;
            this.lblGameDirPath.Location = new System.Drawing.Point(189, 62);
            this.lblGameDirPath.Name = "lblGameDirPath";
            this.lblGameDirPath.Size = new System.Drawing.Size(16, 15);
            this.lblGameDirPath.TabIndex = 14;
            this.lblGameDirPath.Text = "...";
            // 
            // lblDocsDirPath
            // 
            this.lblDocsDirPath.AutoSize = true;
            this.lblDocsDirPath.Location = new System.Drawing.Point(189, 91);
            this.lblDocsDirPath.Name = "lblDocsDirPath";
            this.lblDocsDirPath.Size = new System.Drawing.Size(16, 15);
            this.lblDocsDirPath.TabIndex = 15;
            this.lblDocsDirPath.Text = "...";
            // 
            // lblToolsDirPath
            // 
            this.lblToolsDirPath.AutoSize = true;
            this.lblToolsDirPath.Location = new System.Drawing.Point(189, 120);
            this.lblToolsDirPath.Name = "lblToolsDirPath";
            this.lblToolsDirPath.Size = new System.Drawing.Size(16, 15);
            this.lblToolsDirPath.TabIndex = 16;
            this.lblToolsDirPath.Text = "...";
            // 
            // txtCustomDirName
            // 
            this.txtCustomDirName.Location = new System.Drawing.Point(189, 146);
            this.txtCustomDirName.Name = "txtCustomDirName";
            this.txtCustomDirName.Size = new System.Drawing.Size(288, 23);
            this.txtCustomDirName.TabIndex = 17;
            this.txtCustomDirName.TextChanged += new System.EventHandler(this.txtCustomDirName_TextChanged);
            // 
            // lstCustomDir
            // 
            this.lstCustomDir.FormattingEnabled = true;
            this.lstCustomDir.ItemHeight = 15;
            this.lstCustomDir.Location = new System.Drawing.Point(0, 175);
            this.lstCustomDir.Name = "lstCustomDir";
            this.lstCustomDir.Size = new System.Drawing.Size(477, 49);
            this.lstCustomDir.TabIndex = 18;
            this.lstCustomDir.SelectedIndexChanged += new System.EventHandler(this.lstCustomDir_SelectedIndexChanged);
            // 
            // btnRemoveDir
            // 
            this.btnRemoveDir.Enabled = false;
            this.btnRemoveDir.Location = new System.Drawing.Point(483, 175);
            this.btnRemoveDir.Name = "btnRemoveDir";
            this.btnRemoveDir.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveDir.TabIndex = 19;
            this.btnRemoveDir.Text = "Remove";
            this.btnRemoveDir.UseVisualStyleBackColor = true;
            this.btnRemoveDir.Click += new System.EventHandler(this.btnRemoveDir_Click);
            // 
            // btnSaveSettings
            // 
            this.btnSaveSettings.Enabled = false;
            this.btnSaveSettings.Location = new System.Drawing.Point(0, 230);
            this.btnSaveSettings.Name = "btnSaveSettings";
            this.btnSaveSettings.Size = new System.Drawing.Size(92, 23);
            this.btnSaveSettings.TabIndex = 20;
            this.btnSaveSettings.Text = "Save Settings";
            this.btnSaveSettings.UseVisualStyleBackColor = true;
            this.btnSaveSettings.Click += new System.EventHandler(this.btnSaveSettings_Click);
            // 
            // btnScanGame
            // 
            this.btnScanGame.Enabled = false;
            this.btnScanGame.Location = new System.Drawing.Point(483, 230);
            this.btnScanGame.Name = "btnScanGame";
            this.btnScanGame.Size = new System.Drawing.Size(75, 23);
            this.btnScanGame.TabIndex = 21;
            this.btnScanGame.Text = "Scan Game";
            this.btnScanGame.UseVisualStyleBackColor = true;
            this.btnScanGame.Click += new System.EventHandler(this.btnScanGame_Click);
            // 
            // chkBackupGame
            // 
            this.chkBackupGame.AutoSize = true;
            this.chkBackupGame.Location = new System.Drawing.Point(352, 233);
            this.chkBackupGame.Name = "chkBackupGame";
            this.chkBackupGame.Size = new System.Drawing.Size(125, 19);
            this.chkBackupGame.TabIndex = 22;
            this.chkBackupGame.Text = "Backup Game Files";
            this.chkBackupGame.UseVisualStyleBackColor = true;
            // 
            // bgwScanGame
            // 
            this.bgwScanGame.WorkerReportsProgress = true;
            this.bgwScanGame.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwScanGame_DoWork);
            this.bgwScanGame.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgwScanGame_ProgressChanged);
            this.bgwScanGame.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwScanGame_RunWorkerCompleted);
            // 
            // GamePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.chkBackupGame);
            this.Controls.Add(this.btnScanGame);
            this.Controls.Add(this.btnSaveSettings);
            this.Controls.Add(this.btnRemoveDir);
            this.Controls.Add(this.lstCustomDir);
            this.Controls.Add(this.txtCustomDirName);
            this.Controls.Add(this.lblToolsDirPath);
            this.Controls.Add(this.lblDocsDirPath);
            this.Controls.Add(this.lblGameDirPath);
            this.Controls.Add(this.lblGuidValue);
            this.Controls.Add(this.btnCustomDir);
            this.Controls.Add(this.btnGameDir);
            this.Controls.Add(this.btnToolsDir);
            this.Controls.Add(this.btnDocsDir);
            this.Controls.Add(this.txtGameName);
            this.Controls.Add(this.lblCustomDir);
            this.Controls.Add(this.lblToolsDir);
            this.Controls.Add(this.lblDocsDir);
            this.Controls.Add(this.lblGameDir);
            this.Controls.Add(this.lblGameGuid);
            this.Controls.Add(this.lblGameName);
            this.Name = "GamePanel";
            this.Size = new System.Drawing.Size(561, 272);
            this.Load += new System.EventHandler(this.GamePanel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGameName;
        private System.Windows.Forms.Label lblGameGuid;
        private System.Windows.Forms.Label lblGameDir;
        private System.Windows.Forms.Label lblDocsDir;
        private System.Windows.Forms.Label lblToolsDir;
        private System.Windows.Forms.Label lblCustomDir;
        private System.Windows.Forms.TextBox txtGameName;
        private System.Windows.Forms.Button btnDocsDir;
        private System.Windows.Forms.Button btnGameDir;
        private System.Windows.Forms.Label lblGuidValue;
        private System.Windows.Forms.Label lblGameDirPath;
        private System.Windows.Forms.Label lblDocsDirPath;
        private System.Windows.Forms.Label lblToolsDirPath;
        private System.Windows.Forms.TextBox txtCustomDirName;
        private System.Windows.Forms.Button btnToolsDir;
        private System.Windows.Forms.Button btnCustomDir;
        private System.Windows.Forms.ListBox lstCustomDir;
        private System.Windows.Forms.Button btnRemoveDir;
        private System.Windows.Forms.Button btnSaveSettings;
        private System.Windows.Forms.CheckBox chkBackupGame;
        private System.Windows.Forms.Button btnScanGame;
        private System.ComponentModel.BackgroundWorker bgwScanGame;
    }
}
