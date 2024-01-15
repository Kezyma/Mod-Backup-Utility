namespace Kezyma.Modding.ModBackup.Windows
{
    partial class AddGame
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGameDir = new System.Windows.Forms.Button();
            this.btnDocDir = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnToolDir = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGame = new System.Windows.Forms.TextBox();
            this.lstCustomDir = new System.Windows.Forms.ListBox();
            this.btnCustomDir = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCustomDir = new System.Windows.Forms.TextBox();
            this.lblToolsDir = new System.Windows.Forms.Label();
            this.lblDocsDir = new System.Windows.Forms.Label();
            this.lblGameDir = new System.Windows.Forms.Label();
            this.btnRmCustom = new System.Windows.Forms.Button();
            this.chkBackupGame = new System.Windows.Forms.CheckBox();
            this.btnScanGame = new System.Windows.Forms.Button();
            this.prgScanGame = new System.Windows.Forms.ProgressBar();
            this.lblStatusText = new System.Windows.Forms.Label();
            this.btnGameList = new System.Windows.Forms.Button();
            this.backgroundBackupper = new System.ComponentModel.BackgroundWorker();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Game:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Game Directory:";
            // 
            // btnGameDir
            // 
            this.btnGameDir.Location = new System.Drawing.Point(98, 25);
            this.btnGameDir.Margin = new System.Windows.Forms.Padding(0);
            this.btnGameDir.Name = "btnGameDir";
            this.btnGameDir.Size = new System.Drawing.Size(75, 23);
            this.btnGameDir.TabIndex = 3;
            this.btnGameDir.Text = "Select";
            this.btnGameDir.UseVisualStyleBackColor = true;
            this.btnGameDir.Click += new System.EventHandler(this.btnGameDir_Click);
            // 
            // btnDocDir
            // 
            this.btnDocDir.Location = new System.Drawing.Point(98, 48);
            this.btnDocDir.Margin = new System.Windows.Forms.Padding(0);
            this.btnDocDir.Name = "btnDocDir";
            this.btnDocDir.Size = new System.Drawing.Size(75, 23);
            this.btnDocDir.TabIndex = 4;
            this.btnDocDir.Text = "Select";
            this.btnDocDir.UseVisualStyleBackColor = true;
            this.btnDocDir.Click += new System.EventHandler(this.btnDocDir_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Docs Directory:";
            // 
            // btnToolDir
            // 
            this.btnToolDir.Location = new System.Drawing.Point(98, 71);
            this.btnToolDir.Margin = new System.Windows.Forms.Padding(0);
            this.btnToolDir.Name = "btnToolDir";
            this.btnToolDir.Size = new System.Drawing.Size(75, 23);
            this.btnToolDir.TabIndex = 6;
            this.btnToolDir.Text = "Select";
            this.btnToolDir.UseVisualStyleBackColor = true;
            this.btnToolDir.Click += new System.EventHandler(this.btnToolDir_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tools Directory:";
            // 
            // txtGame
            // 
            this.txtGame.Location = new System.Drawing.Point(98, 2);
            this.txtGame.Margin = new System.Windows.Forms.Padding(0);
            this.txtGame.Name = "txtGame";
            this.txtGame.Size = new System.Drawing.Size(299, 23);
            this.txtGame.TabIndex = 8;
            this.txtGame.TextChanged += new System.EventHandler(this.txtGame_TextChanged);
            // 
            // lstCustomDir
            // 
            this.lstCustomDir.FormattingEnabled = true;
            this.lstCustomDir.ItemHeight = 15;
            this.lstCustomDir.Items.AddRange(new object[] {
            "No Custom Directories Selected"});
            this.lstCustomDir.Location = new System.Drawing.Point(3, 121);
            this.lstCustomDir.Name = "lstCustomDir";
            this.lstCustomDir.Size = new System.Drawing.Size(394, 49);
            this.lstCustomDir.TabIndex = 9;
            this.lstCustomDir.SelectedIndexChanged += new System.EventHandler(this.lstCustomDir_SelectedIndexChanged);
            // 
            // btnCustomDir
            // 
            this.btnCustomDir.Enabled = false;
            this.btnCustomDir.Location = new System.Drawing.Point(98, 94);
            this.btnCustomDir.Margin = new System.Windows.Forms.Padding(0);
            this.btnCustomDir.Name = "btnCustomDir";
            this.btnCustomDir.Size = new System.Drawing.Size(75, 23);
            this.btnCustomDir.TabIndex = 10;
            this.btnCustomDir.Text = "Select";
            this.btnCustomDir.UseVisualStyleBackColor = true;
            this.btnCustomDir.Click += new System.EventHandler(this.btnCustomDir_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Custom:";
            // 
            // txtCustomDir
            // 
            this.txtCustomDir.Location = new System.Drawing.Point(176, 94);
            this.txtCustomDir.Margin = new System.Windows.Forms.Padding(0);
            this.txtCustomDir.Name = "txtCustomDir";
            this.txtCustomDir.Size = new System.Drawing.Size(221, 23);
            this.txtCustomDir.TabIndex = 12;
            this.txtCustomDir.TextChanged += new System.EventHandler(this.txtCustomDir_TextChanged);
            // 
            // lblToolsDir
            // 
            this.lblToolsDir.AutoSize = true;
            this.lblToolsDir.Location = new System.Drawing.Point(176, 75);
            this.lblToolsDir.Name = "lblToolsDir";
            this.lblToolsDir.Size = new System.Drawing.Size(16, 15);
            this.lblToolsDir.TabIndex = 13;
            this.lblToolsDir.Text = "...";
            // 
            // lblDocsDir
            // 
            this.lblDocsDir.AutoSize = true;
            this.lblDocsDir.Location = new System.Drawing.Point(176, 52);
            this.lblDocsDir.Name = "lblDocsDir";
            this.lblDocsDir.Size = new System.Drawing.Size(16, 15);
            this.lblDocsDir.TabIndex = 14;
            this.lblDocsDir.Text = "...";
            // 
            // lblGameDir
            // 
            this.lblGameDir.AutoSize = true;
            this.lblGameDir.Location = new System.Drawing.Point(176, 29);
            this.lblGameDir.Name = "lblGameDir";
            this.lblGameDir.Size = new System.Drawing.Size(16, 15);
            this.lblGameDir.TabIndex = 15;
            this.lblGameDir.Text = "...";
            // 
            // btnRmCustom
            // 
            this.btnRmCustom.Enabled = false;
            this.btnRmCustom.Location = new System.Drawing.Point(3, 173);
            this.btnRmCustom.Margin = new System.Windows.Forms.Padding(0);
            this.btnRmCustom.Name = "btnRmCustom";
            this.btnRmCustom.Size = new System.Drawing.Size(75, 23);
            this.btnRmCustom.TabIndex = 16;
            this.btnRmCustom.Text = "Remove";
            this.btnRmCustom.UseVisualStyleBackColor = true;
            this.btnRmCustom.Click += new System.EventHandler(this.btnRmCustom_Click);
            // 
            // chkBackupGame
            // 
            this.chkBackupGame.AutoSize = true;
            this.chkBackupGame.Checked = true;
            this.chkBackupGame.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBackupGame.Location = new System.Drawing.Point(81, 229);
            this.chkBackupGame.Name = "chkBackupGame";
            this.chkBackupGame.Size = new System.Drawing.Size(125, 19);
            this.chkBackupGame.TabIndex = 17;
            this.chkBackupGame.Text = "Backup Game Files";
            this.chkBackupGame.UseVisualStyleBackColor = true;
            // 
            // btnScanGame
            // 
            this.btnScanGame.Enabled = false;
            this.btnScanGame.Location = new System.Drawing.Point(3, 226);
            this.btnScanGame.Margin = new System.Windows.Forms.Padding(0);
            this.btnScanGame.Name = "btnScanGame";
            this.btnScanGame.Size = new System.Drawing.Size(75, 23);
            this.btnScanGame.TabIndex = 18;
            this.btnScanGame.Text = "Run Scan";
            this.btnScanGame.UseVisualStyleBackColor = true;
            this.btnScanGame.Click += new System.EventHandler(this.btnScanGame_Click);
            // 
            // prgScanGame
            // 
            this.prgScanGame.Location = new System.Drawing.Point(3, 252);
            this.prgScanGame.Name = "prgScanGame";
            this.prgScanGame.Size = new System.Drawing.Size(394, 21);
            this.prgScanGame.TabIndex = 19;
            // 
            // lblStatusText
            // 
            this.lblStatusText.AutoSize = true;
            this.lblStatusText.BackColor = System.Drawing.Color.Transparent;
            this.lblStatusText.Location = new System.Drawing.Point(3, 276);
            this.lblStatusText.Name = "lblStatusText";
            this.lblStatusText.Size = new System.Drawing.Size(0, 15);
            this.lblStatusText.TabIndex = 20;
            // 
            // btnGameList
            // 
            this.btnGameList.Location = new System.Drawing.Point(3, 306);
            this.btnGameList.Name = "btnGameList";
            this.btnGameList.Size = new System.Drawing.Size(92, 23);
            this.btnGameList.TabIndex = 21;
            this.btnGameList.Text = "<- Game List";
            this.btnGameList.UseVisualStyleBackColor = true;
            this.btnGameList.Click += new System.EventHandler(this.btnGameList_Click);
            // 
            // backgroundBackupper
            // 
            this.backgroundBackupper.WorkerReportsProgress = true;
            this.backgroundBackupper.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundBackupper_DoWork);
            this.backgroundBackupper.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundBackupper_ProgressChanged);
            this.backgroundBackupper.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundBackupper_RunWorkerCompleted);
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Location = new System.Drawing.Point(300, 173);
            this.btnSaveChanges.Margin = new System.Windows.Forms.Padding(0);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(97, 23);
            this.btnSaveChanges.TabIndex = 22;
            this.btnSaveChanges.Text = "Save Changes";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Visible = false;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // AddGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.btnGameList);
            this.Controls.Add(this.lblStatusText);
            this.Controls.Add(this.prgScanGame);
            this.Controls.Add(this.btnScanGame);
            this.Controls.Add(this.chkBackupGame);
            this.Controls.Add(this.btnRmCustom);
            this.Controls.Add(this.lblGameDir);
            this.Controls.Add(this.lblDocsDir);
            this.Controls.Add(this.lblToolsDir);
            this.Controls.Add(this.txtCustomDir);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCustomDir);
            this.Controls.Add(this.lstCustomDir);
            this.Controls.Add(this.txtGame);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnToolDir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDocDir);
            this.Controls.Add(this.btnGameDir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddGame";
            this.Size = new System.Drawing.Size(400, 332);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGameDir;
        private System.Windows.Forms.Button btnDocDir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lstCustomDir;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCustomDir;
        private System.Windows.Forms.Label lblToolsDir;
        private System.Windows.Forms.Button btnToolDir;
        private System.Windows.Forms.Button btnCustomDir;
        private System.Windows.Forms.TextBox txtGame;
        private System.Windows.Forms.Label lblDocsDir;
        private System.Windows.Forms.Label lblGameDir;
        private System.Windows.Forms.Button btnRmCustom;
        private System.Windows.Forms.CheckBox chkBackupGame;
        private System.Windows.Forms.Button btnScanGame;
        private System.Windows.Forms.ProgressBar prgScanGame;
        private System.Windows.Forms.Label lblStatusText;
        private System.Windows.Forms.Button btnGameList;
        private System.ComponentModel.BackgroundWorker backgroundBackupper;
        private System.Windows.Forms.Button btnSaveChanges;
    }
}
