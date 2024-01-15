

namespace Kezyma.Modding.ModBackup.Windows
{
    partial class RestoreBackup
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
            this.lblGame = new System.Windows.Forms.Label();
            this.btnGameList = new System.Windows.Forms.Button();
            this.btnRestore = new System.Windows.Forms.Button();
            this.chkDeleteExisting = new System.Windows.Forms.CheckBox();
            this.backgroundRestorer = new System.ComponentModel.BackgroundWorker();
            this.prgRestore = new System.Windows.Forms.ProgressBar();
            this.lblStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblGame
            // 
            this.lblGame.AutoSize = true;
            this.lblGame.Location = new System.Drawing.Point(104, 4);
            this.lblGame.Name = "lblGame";
            this.lblGame.Size = new System.Drawing.Size(38, 15);
            this.lblGame.TabIndex = 0;
            this.lblGame.Text = "label1";
            // 
            // btnGameList
            // 
            this.btnGameList.Location = new System.Drawing.Point(0, 0);
            this.btnGameList.Name = "btnGameList";
            this.btnGameList.Size = new System.Drawing.Size(98, 23);
            this.btnGameList.TabIndex = 1;
            this.btnGameList.Text = "<- Game List";
            this.btnGameList.UseVisualStyleBackColor = true;
            this.btnGameList.Click += new System.EventHandler(this.btnGameList_Click);
            // 
            // btnRestore
            // 
            this.btnRestore.Location = new System.Drawing.Point(0, 29);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(98, 23);
            this.btnRestore.TabIndex = 2;
            this.btnRestore.Text = "Restore";
            this.btnRestore.UseVisualStyleBackColor = true;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // chkDeleteExisting
            // 
            this.chkDeleteExisting.AutoSize = true;
            this.chkDeleteExisting.Location = new System.Drawing.Point(104, 32);
            this.chkDeleteExisting.Name = "chkDeleteExisting";
            this.chkDeleteExisting.Size = new System.Drawing.Size(103, 19);
            this.chkDeleteExisting.TabIndex = 3;
            this.chkDeleteExisting.Text = "Delete Existing";
            this.chkDeleteExisting.UseVisualStyleBackColor = true;
            // 
            // backgroundRestorer
            // 
            this.backgroundRestorer.WorkerReportsProgress = true;
            this.backgroundRestorer.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundRestorer.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_ProgressChanged);
            this.backgroundRestorer.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundRestorer_RunWorkerCompleted);
            // 
            // prgRestore
            // 
            this.prgRestore.Location = new System.Drawing.Point(0, 58);
            this.prgRestore.Name = "prgRestore";
            this.prgRestore.Size = new System.Drawing.Size(342, 21);
            this.prgRestore.TabIndex = 4;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(0, 82);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(16, 15);
            this.lblStatus.TabIndex = 5;
            this.lblStatus.Text = "...";
            // 
            // RestoreBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.prgRestore);
            this.Controls.Add(this.chkDeleteExisting);
            this.Controls.Add(this.btnRestore);
            this.Controls.Add(this.btnGameList);
            this.Controls.Add(this.lblGame);
            this.Name = "RestoreBackup";
            this.Size = new System.Drawing.Size(345, 97);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGame;
        private System.Windows.Forms.Button btnGameList;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.CheckBox chkDeleteExisting;
        private System.ComponentModel.BackgroundWorker backgroundRestorer;
        private System.Windows.Forms.ProgressBar prgRestore;
        private System.Windows.Forms.Label lblStatus;
    }
}
