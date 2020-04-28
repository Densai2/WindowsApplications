namespace DanielGraceWinApp
{
    partial class UserWin
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
            this.YouWon = new System.Windows.Forms.Label();
            this.ThumbsUp = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ThumbsUp)).BeginInit();
            this.SuspendLayout();
            // 
            // YouWon
            // 
            this.YouWon.AutoSize = true;
            this.YouWon.BackColor = System.Drawing.Color.Orange;
            this.YouWon.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YouWon.Location = new System.Drawing.Point(344, 119);
            this.YouWon.Name = "YouWon";
            this.YouWon.Size = new System.Drawing.Size(218, 46);
            this.YouWon.TabIndex = 0;
            this.YouWon.Text = "You Won!!!";
            this.YouWon.Click += new System.EventHandler(this.YouWin);
            // 
            // ThumbsUp
            // 
            this.ThumbsUp.BackgroundImage = global::DanielGraceWinApp.Properties.Resources.Thumbs_Up_Sign_Emoji_Icon_ios10_large1;
            this.ThumbsUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ThumbsUp.Location = new System.Drawing.Point(361, 217);
            this.ThumbsUp.Name = "ThumbsUp";
            this.ThumbsUp.Size = new System.Drawing.Size(191, 224);
            this.ThumbsUp.TabIndex = 1;
            this.ThumbsUp.TabStop = false;
            this.ThumbsUp.Click += new System.EventHandler(this.HappyFace);
            // 
            // UserWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(939, 619);
            this.Controls.Add(this.ThumbsUp);
            this.Controls.Add(this.YouWon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserWin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserWin";
            this.Click += new System.EventHandler(this.UserWon);
            ((System.ComponentModel.ISupportInitialize)(this.ThumbsUp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label YouWon;
        private System.Windows.Forms.PictureBox ThumbsUp;
    }
}