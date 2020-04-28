namespace DanielGraceWinApp
{
    partial class RPSGameOpenSplash
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
            this.Rock = new System.Windows.Forms.PictureBox();
            this.Paper = new System.Windows.Forms.PictureBox();
            this.Scissors = new System.Windows.Forms.PictureBox();
            this.LabelBegin = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Rock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Paper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Scissors)).BeginInit();
            this.SuspendLayout();
            // 
            // Rock
            // 
            this.Rock.BackgroundImage = global::DanielGraceWinApp.Properties.Resources.Rock;
            this.Rock.Location = new System.Drawing.Point(2, 91);
            this.Rock.Name = "Rock";
            this.Rock.Size = new System.Drawing.Size(254, 258);
            this.Rock.TabIndex = 0;
            this.Rock.TabStop = false;
            // 
            // Paper
            // 
            this.Paper.BackgroundImage = global::DanielGraceWinApp.Properties.Resources.Paper;
            this.Paper.Location = new System.Drawing.Point(277, 91);
            this.Paper.Name = "Paper";
            this.Paper.Size = new System.Drawing.Size(254, 258);
            this.Paper.TabIndex = 1;
            this.Paper.TabStop = false;
            this.Paper.Click += new System.EventHandler(this.ImageRock);
            // 
            // Scissors
            // 
            this.Scissors.BackgroundImage = global::DanielGraceWinApp.Properties.Resources.Scissors;
            this.Scissors.Location = new System.Drawing.Point(537, 91);
            this.Scissors.Name = "Scissors";
            this.Scissors.Size = new System.Drawing.Size(254, 258);
            this.Scissors.TabIndex = 2;
            this.Scissors.TabStop = false;
            this.Scissors.Click += new System.EventHandler(this.ImagePaper);
            // 
            // LabelBegin
            // 
            this.LabelBegin.AutoSize = true;
            this.LabelBegin.BackColor = System.Drawing.Color.LightBlue;
            this.LabelBegin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LabelBegin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelBegin.Location = new System.Drawing.Point(265, 387);
            this.LabelBegin.Name = "LabelBegin";
            this.LabelBegin.Size = new System.Drawing.Size(280, 33);
            this.LabelBegin.TabIndex = 3;
            this.LabelBegin.Text = "Click to begin playing!";
            this.LabelBegin.Click += new System.EventHandler(this.ImageScissors);
            // 
            // RPSGameOpenSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DanielGraceWinApp.Properties.Resources._87b36abed58b3295ff678aae11e3fb66;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LabelBegin);
            this.Controls.Add(this.Scissors);
            this.Controls.Add(this.Paper);
            this.Controls.Add(this.Rock);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RPSGameOpenSplash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RPSGameOpenSplash";
            this.Click += new System.EventHandler(this.RPSGame_OpenSplash);
            ((System.ComponentModel.ISupportInitialize)(this.Rock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Paper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Scissors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Rock;
        private System.Windows.Forms.PictureBox Paper;
        private System.Windows.Forms.PictureBox Scissors;
        private System.Windows.Forms.Label LabelBegin;
    }
}