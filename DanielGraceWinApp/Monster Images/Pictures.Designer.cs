namespace DanielGraceWinApp
{
    partial class Pictures
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
            this.CboChoice = new System.Windows.Forms.ComboBox();
            this.PictureChoice = new System.Windows.Forms.PictureBox();
            this.Quit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PictureChoice)).BeginInit();
            this.SuspendLayout();
            // 
            // CboChoice
            // 
            this.CboChoice.FormattingEnabled = true;
            this.CboChoice.Items.AddRange(new object[] {
            "Alien",
            "Banshee",
            "Godzilla",
            "Mike",
            "Sid",
            "Zombie"});
            this.CboChoice.Location = new System.Drawing.Point(75, 110);
            this.CboChoice.Name = "CboChoice";
            this.CboChoice.Size = new System.Drawing.Size(129, 21);
            this.CboChoice.TabIndex = 0;
            this.CboChoice.Text = "Choose your monster!";
            this.CboChoice.SelectedIndexChanged += new System.EventHandler(this.CboChoice_SelectedIndexChanged);
            // 
            // PictureChoice
            // 
            this.PictureChoice.Location = new System.Drawing.Point(299, 12);
            this.PictureChoice.Name = "PictureChoice";
            this.PictureChoice.Size = new System.Drawing.Size(260, 215);
            this.PictureChoice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureChoice.TabIndex = 1;
            this.PictureChoice.TabStop = false;
            // 
            // Quit
            // 
            this.Quit.Location = new System.Drawing.Point(529, 247);
            this.Quit.Name = "Quit";
            this.Quit.Size = new System.Drawing.Size(75, 23);
            this.Quit.TabIndex = 2;
            this.Quit.Text = "Quit";
            this.Quit.UseVisualStyleBackColor = true;
            this.Quit.Click += new System.EventHandler(this.Quit_Click);
            // 
            // Pictures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 282);
            this.Controls.Add(this.Quit);
            this.Controls.Add(this.PictureChoice);
            this.Controls.Add(this.CboChoice);
            this.Name = "Pictures";
            this.Text = "Pictures";
            ((System.ComponentModel.ISupportInitialize)(this.PictureChoice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox CboChoice;
        private System.Windows.Forms.PictureBox PictureChoice;
        private System.Windows.Forms.Button Quit;
    }
}