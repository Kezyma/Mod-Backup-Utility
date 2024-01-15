
namespace Kezyma.Modding.ModBackup.Windows
{
    partial class GameList
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
            this.lstGameList = new System.Windows.Forms.ListBox();
            this.btnAddGame = new System.Windows.Forms.Button();
            this.btnDeleteGame = new System.Windows.Forms.Button();
            this.btnUpdateGame = new System.Windows.Forms.Button();
            this.btnRestoreGame = new System.Windows.Forms.Button();
            this.btnManageMods = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstGameList
            // 
            this.lstGameList.FormattingEnabled = true;
            this.lstGameList.ItemHeight = 15;
            this.lstGameList.Items.AddRange(new object[] {
            "No Games"});
            this.lstGameList.Location = new System.Drawing.Point(0, 3);
            this.lstGameList.Name = "lstGameList";
            this.lstGameList.Size = new System.Drawing.Size(167, 139);
            this.lstGameList.TabIndex = 0;
            this.lstGameList.SelectedIndexChanged += new System.EventHandler(this.lstGameList_SelectedIndexChanged);
            // 
            // btnAddGame
            // 
            this.btnAddGame.Location = new System.Drawing.Point(173, 3);
            this.btnAddGame.Name = "btnAddGame";
            this.btnAddGame.Size = new System.Drawing.Size(99, 23);
            this.btnAddGame.TabIndex = 1;
            this.btnAddGame.Text = "Add Game";
            this.btnAddGame.UseVisualStyleBackColor = true;
            this.btnAddGame.Click += new System.EventHandler(this.btnAddGame_Click);
            // 
            // btnDeleteGame
            // 
            this.btnDeleteGame.Enabled = false;
            this.btnDeleteGame.Location = new System.Drawing.Point(173, 32);
            this.btnDeleteGame.Name = "btnDeleteGame";
            this.btnDeleteGame.Size = new System.Drawing.Size(99, 23);
            this.btnDeleteGame.TabIndex = 2;
            this.btnDeleteGame.Text = "Delete Game";
            this.btnDeleteGame.UseVisualStyleBackColor = true;
            this.btnDeleteGame.Click += new System.EventHandler(this.btnDeleteGame_Click);
            // 
            // btnUpdateGame
            // 
            this.btnUpdateGame.Enabled = false;
            this.btnUpdateGame.Location = new System.Drawing.Point(173, 61);
            this.btnUpdateGame.Name = "btnUpdateGame";
            this.btnUpdateGame.Size = new System.Drawing.Size(99, 23);
            this.btnUpdateGame.TabIndex = 3;
            this.btnUpdateGame.Text = "Update Game";
            this.btnUpdateGame.UseVisualStyleBackColor = true;
            this.btnUpdateGame.Click += new System.EventHandler(this.btnUpdateGame_Click);
            // 
            // btnRestoreGame
            // 
            this.btnRestoreGame.Enabled = false;
            this.btnRestoreGame.Location = new System.Drawing.Point(173, 90);
            this.btnRestoreGame.Name = "btnRestoreGame";
            this.btnRestoreGame.Size = new System.Drawing.Size(99, 23);
            this.btnRestoreGame.TabIndex = 4;
            this.btnRestoreGame.Text = "Restore Game";
            this.btnRestoreGame.UseVisualStyleBackColor = true;
            this.btnRestoreGame.Click += new System.EventHandler(this.btnRestoreGame_Click);
            // 
            // btnManageMods
            // 
            this.btnManageMods.Enabled = false;
            this.btnManageMods.Location = new System.Drawing.Point(173, 119);
            this.btnManageMods.Name = "btnManageMods";
            this.btnManageMods.Size = new System.Drawing.Size(99, 23);
            this.btnManageMods.TabIndex = 5;
            this.btnManageMods.Text = "Manage Mods";
            this.btnManageMods.UseVisualStyleBackColor = true;
            this.btnManageMods.Click += new System.EventHandler(this.btnManageMods_Click);
            // 
            // GameList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly;
            this.Controls.Add(this.btnManageMods);
            this.Controls.Add(this.btnRestoreGame);
            this.Controls.Add(this.btnUpdateGame);
            this.Controls.Add(this.btnDeleteGame);
            this.Controls.Add(this.btnAddGame);
            this.Controls.Add(this.lstGameList);
            this.Name = "GameList";
            this.Size = new System.Drawing.Size(275, 145);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstGameList;
        private System.Windows.Forms.Button btnAddGame;
        private System.Windows.Forms.Button btnDeleteGame;
        private System.Windows.Forms.Button btnUpdateGame;
        private System.Windows.Forms.Button btnRestoreGame;
        private System.Windows.Forms.Button btnManageMods;
    }
}
