
namespace Kezyma.Modding.ModBackup.Windows
{
    partial class Games
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
            this.lblGamesList = new System.Windows.Forms.Label();
            this.btnDeleteGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstGameList
            // 
            this.lstGameList.FormattingEnabled = true;
            this.lstGameList.ItemHeight = 15;
            this.lstGameList.Location = new System.Drawing.Point(3, 50);
            this.lstGameList.Name = "lstGameList";
            this.lstGameList.Size = new System.Drawing.Size(155, 499);
            this.lstGameList.TabIndex = 9;
            this.lstGameList.SelectedIndexChanged += new System.EventHandler(this.lstGameList_SelectedIndexChanged);
            // 
            // btnAddGame
            // 
            this.btnAddGame.Location = new System.Drawing.Point(2, 21);
            this.btnAddGame.Name = "btnAddGame";
            this.btnAddGame.Size = new System.Drawing.Size(75, 23);
            this.btnAddGame.TabIndex = 7;
            this.btnAddGame.Text = "Add";
            this.btnAddGame.UseVisualStyleBackColor = true;
            this.btnAddGame.Click += new System.EventHandler(this.btnAddGame_Click);
            // 
            // lblGamesList
            // 
            this.lblGamesList.AutoSize = true;
            this.lblGamesList.Location = new System.Drawing.Point(3, 3);
            this.lblGamesList.Name = "lblGamesList";
            this.lblGamesList.Size = new System.Drawing.Size(43, 15);
            this.lblGamesList.TabIndex = 10;
            this.lblGamesList.Text = "Games";
            this.lblGamesList.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnDeleteGame
            // 
            this.btnDeleteGame.Enabled = false;
            this.btnDeleteGame.Location = new System.Drawing.Point(83, 21);
            this.btnDeleteGame.Name = "btnDeleteGame";
            this.btnDeleteGame.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteGame.TabIndex = 8;
            this.btnDeleteGame.Text = "Delete";
            this.btnDeleteGame.UseVisualStyleBackColor = true;
            this.btnDeleteGame.Click += new System.EventHandler(this.btnDeleteGame_Click);
            // 
            // Games
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.lstGameList);
            this.Controls.Add(this.btnAddGame);
            this.Controls.Add(this.lblGamesList);
            this.Controls.Add(this.btnDeleteGame);
            this.Name = "Games";
            this.Size = new System.Drawing.Size(161, 552);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstGameList;
        private System.Windows.Forms.Button btnAddGame;
        private System.Windows.Forms.Label lblGamesList;
        private System.Windows.Forms.Button btnDeleteGame;
    }
}
