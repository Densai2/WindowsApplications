namespace DanielGraceWinApp
{
    partial class Draw
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
            this.LabelDraw = new System.Windows.Forms.Label();
            this.Frowning = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Frowning)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelDraw
            // 
            this.LabelDraw.AutoSize = true;
            this.LabelDraw.BackColor = System.Drawing.Color.LightCoral;
            this.LabelDraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDraw.Location = new System.Drawing.Point(327, 116);
            this.LabelDraw.Name = "LabelDraw";
            this.LabelDraw.Size = new System.Drawing.Size(304, 46);
            this.LabelDraw.TabIndex = 0;
            this.LabelDraw.Text = "It\'s..... A draw!?!";
            this.LabelDraw.Click += new System.EventHandler(this.Drew);
            // 
            // Frowning
            // 
            this.Frowning.BackgroundImage = global::DanielGraceWinApp.Properties.Resources.confused_emoji_png;
            this.Frowning.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Frowning.Location = new System.Drawing.Point(358, 187);
            this.Frowning.Name = "Frowning";
            this.Frowning.Size = new System.Drawing.Size(241, 252);
            this.Frowning.TabIndex = 1;
            this.Frowning.TabStop = false;
            this.Frowning.Click += new System.EventHandler(this.FrownFace);
            // 
            // Draw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(939, 619);
            this.Controls.Add(this.Frowning);
            this.Controls.Add(this.LabelDraw);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Draw";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Draw";
            this.Click += new System.EventHandler(this.Drawn);
            ((System.ComponentModel.ISupportInitialize)(this.Frowning)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelDraw;
        private System.Windows.Forms.PictureBox Frowning;
    }
}