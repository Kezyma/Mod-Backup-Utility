

namespace Kezyma.Modding.ModBackup.Windows
{
    partial class RestorePanel
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
            this.btnRestore = new System.Windows.Forms.Button();
            this.chkDeleteExisting = new System.Windows.Forms.CheckBox();
            this.backgroundRestorer = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // btnRestore
            // 
            this.btnRestore.Location = new System.Drawing.Point(0, 0);
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
            this.chkDeleteExisting.Location = new System.Drawing.Point(104, 3);
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
            // RestorePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.chkDeleteExisting);
            this.Controls.Add(this.btnRestore);
            this.Name = "RestorePanel";
            this.Size = new System.Drawing.Size(210, 26);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.CheckBox chkDeleteExisting;
        private System.ComponentModel.BackgroundWorker backgroundRestorer;
    }
}
