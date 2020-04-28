namespace DanielGraceWinApp
{
    partial class CompWins
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
            this.YouLost = new System.Windows.Forms.Label();
            this.Crying = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Crying)).BeginInit();
            this.SuspendLayout();
            // 
            // YouLost
            // 
            this.YouLost.AutoSize = true;
            this.YouLost.BackColor = System.Drawing.Color.Plum;
            this.YouLost.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YouLost.ForeColor = System.Drawing.Color.Purple;
            this.YouLost.Location = new System.Drawing.Point(356, 117);
            this.YouLost.Name = "YouLost";
            this.YouLost.Size = new System.Drawing.Size(211, 46);
            this.YouLost.TabIndex = 0;
            this.YouLost.Text = "You Lost...";
            this.YouLost.Click += new System.EventHandler(this.UserLoss);
            // 
            // Crying
            // 
            this.Crying.BackgroundImage = global::DanielGraceWinApp.Properties.Resources._5897a8c3cba9841eabab6156;
            this.Crying.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Crying.Location = new System.Drawing.Point(324, 202);
            this.Crying.Name = "Crying";
            this.Crying.Size = new System.Drawing.Size(268, 260);
            this.Crying.TabIndex = 1;
            this.Crying.TabStop = false;
            this.Crying.Click += new System.EventHandler(this.SadFace);
            // 
            // CompWins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(939, 619);
            this.Controls.Add(this.Crying);
            this.Controls.Add(this.YouLost);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CompWins";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CompWins";
            this.Click += new System.EventHandler(this.ComputerWins);
            ((System.ComponentModel.ISupportInitialize)(this.Crying)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label YouLost;
        private System.Windows.Forms.PictureBox Crying;
    }
}