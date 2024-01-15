
namespace Kezyma.Modding.ModBackup.Windows
{
    partial class Backups
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
            this.lblBackupList = new System.Windows.Forms.Label();
            this.txtBackupName = new System.Windows.Forms.TextBox();
            this.btnBrowseFiles = new System.Windows.Forms.Button();
            this.btnDeleteBackup = new System.Windows.Forms.Button();
            this.btnAddBackup = new System.Windows.Forms.Button();
            this.bgwScanChanges = new System.ComponentModel.BackgroundWorker();
            this.btnRecord = new System.Windows.Forms.Button();
            this.btnSaveRecord = new System.Windows.Forms.Button();
            this.bgwRecordChanges = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // lstBackupList
            // 
            this.lstBackupList.Enabled = false;
            this.lstBackupList.FormattingEnabled = true;
            this.lstBackupList.ItemHeight = 15;
            this.lstBackupList.Location = new System.Drawing.Point(0, 108);
            this.lstBackupList.Name = "lstBackupList";
            this.lstBackupList.Size = new System.Drawing.Size(155, 409);
            this.lstBackupList.TabIndex = 16;
            this.lstBackupList.SelectedIndexChanged += new System.EventHandler(this.lstBackupList_SelectedIndexChanged);
            // 
            // lblBackupList
            // 
            this.lblBackupList.AutoSize = true;
            this.lblBackupList.Location = new System.Drawing.Point(0, 2);
            this.lblBackupList.Name = "lblBackupList";
            this.lblBackupList.Size = new System.Drawing.Size(51, 15);
            this.lblBackupList.TabIndex = 17;
            this.lblBackupList.Text = "Backups";
            // 
            // txtBackupName
            // 
            this.txtBackupName.Enabled = false;
            this.txtBackupName.Location = new System.Drawing.Point(0, 20);
            this.txtBackupName.Name = "txtBackupName";
            this.txtBackupName.Size = new System.Drawing.Size(155, 23);
            this.txtBackupName.TabIndex = 20;
            this.txtBackupName.TextChanged += new System.EventHandler(this.txtBackupName_TextChanged);
            // 
            // btnBrowseFiles
            // 
            this.btnBrowseFiles.Enabled = false;
            this.btnBrowseFiles.Location = new System.Drawing.Point(0, 523);
            this.btnBrowseFiles.Name = "btnBrowseFiles";
            this.btnBrowseFiles.Size = new System.Drawing.Size(155, 23);
            this.btnBrowseFiles.TabIndex = 21;
            this.btnBrowseFiles.Text = "Browse Files";
            this.btnBrowseFiles.UseVisualStyleBackColor = true;
            this.btnBrowseFiles.Click += new System.EventHandler(this.btnBrowseFiles_Click);
            // 
            // btnDeleteBackup
            // 
            this.btnDeleteBackup.Enabled = false;
            this.btnDeleteBackup.Location = new System.Drawing.Point(80, 49);
            this.btnDeleteBackup.Name = "btnDeleteBackup";
            this.btnDeleteBackup.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteBackup.TabIndex = 19;
            this.btnDeleteBackup.Text = "Delete";
            this.btnDeleteBackup.UseVisualStyleBackColor = true;
            this.btnDeleteBackup.Click += new System.EventHandler(this.btnDeleteBackup_Click);
            // 
            // btnAddBackup
            // 
            this.btnAddBackup.Enabled = false;
            this.btnAddBackup.Location = new System.Drawing.Point(0, 49);
            this.btnAddBackup.Name = "btnAddBackup";
            this.btnAddBackup.Size = new System.Drawing.Size(75, 23);
            this.btnAddBackup.TabIndex = 18;
            this.btnAddBackup.Text = "Add";
            this.btnAddBackup.UseVisualStyleBackColor = true;
            this.btnAddBackup.Click += new System.EventHandler(this.btnAddBackup_Click);
            // 
            // bgwScanChanges
            // 
            this.bgwScanChanges.WorkerReportsProgress = true;
            this.bgwScanChanges.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwScanChanges_DoWork);
            this.bgwScanChanges.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgwScanChanges_ProgressChanged);
            this.bgwScanChanges.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwScanChanges_RunWorkerCompleted);
            // 
            // btnRecord
            // 
            this.btnRecord.Enabled = false;
            this.btnRecord.Location = new System.Drawing.Point(0, 78);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(75, 23);
            this.btnRecord.TabIndex = 22;
            this.btnRecord.Text = "Record";
            this.btnRecord.UseVisualStyleBackColor = true;
            this.btnRecord.Click += new System.EventHandler(this.btnRecord_Click);
            // 
            // btnSaveRecord
            // 
            this.btnSaveRecord.Enabled = false;
            this.btnSaveRecord.Location = new System.Drawing.Point(80, 78);
            this.btnSaveRecord.Name = "btnSaveRecord";
            this.btnSaveRecord.Size = new System.Drawing.Size(75, 23);
            this.btnSaveRecord.TabIndex = 23;
            this.btnSaveRecord.Text = "Save";
            this.btnSaveRecord.UseVisualStyleBackColor = true;
            this.btnSaveRecord.Click += new System.EventHandler(this.btnSaveRecord_Click);
            // 
            // bgwRecordChanges
            // 
            this.bgwRecordChanges.WorkerReportsProgress = true;
            this.bgwRecordChanges.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwRecordChanges_DoWork);
            this.bgwRecordChanges.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgwRecordChanges_ProgressChanged);
            this.bgwRecordChanges.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwRecordChanges_RunWorkerCompleted);
            // 
            // Backups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.btnSaveRecord);
            this.Controls.Add(this.btnRecord);
            this.Controls.Add(this.lstBackupList);
            this.Controls.Add(this.lblBackupList);
            this.Controls.Add(this.txtBackupName);
            this.Controls.Add(this.btnBrowseFiles);
            this.Controls.Add(this.btnDeleteBackup);
            this.Controls.Add(this.btnAddBackup);
            this.Name = "Backups";
            this.Size = new System.Drawing.Size(158, 549);
            this.Load += new System.EventHandler(this.Backups_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstBackupList;
        private System.Windows.Forms.Label lblBackupList;
        private System.Windows.Forms.TextBox txtBackupName;
        private System.Windows.Forms.Button btnBrowseFiles;
        private System.Windows.Forms.Button btnDeleteBackup;
        private System.Windows.Forms.Button btnAddBackup;
        private System.ComponentModel.BackgroundWorker bgwScanChanges;
        private System.Windows.Forms.Button btnRecord;
        private System.Windows.Forms.Button btnSaveRecord;
        private System.ComponentModel.BackgroundWorker bgwRecordChanges;
    }
}
