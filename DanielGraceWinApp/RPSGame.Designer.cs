namespace DanielGraceWinApp
{
    partial class RPSGame
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
            this.UserChoice = new System.Windows.Forms.GroupBox();
            this.Scissors = new System.Windows.Forms.RadioButton();
            this.Paper = new System.Windows.Forms.RadioButton();
            this.Rock = new System.Windows.Forms.RadioButton();
            this.ComputerChoice = new System.Windows.Forms.GroupBox();
            this.Play = new System.Windows.Forms.Button();
            this.Result = new System.Windows.Forms.GroupBox();
            this.lblComputerScore = new System.Windows.Forms.Label();
            this.lblUserScore = new System.Windows.Forms.Label();
            this.LabelUserScore = new System.Windows.Forms.Label();
            this.LabelComputerScore = new System.Windows.Forms.Label();
            this.ResultText = new System.Windows.Forms.Label();
            this.Quit = new System.Windows.Forms.Button();
            this.ComputerPicture = new System.Windows.Forms.PictureBox();
            this.UserPicture = new System.Windows.Forms.PictureBox();
            this.UserChoice.SuspendLayout();
            this.ComputerChoice.SuspendLayout();
            this.Result.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ComputerPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // UserChoice
            // 
            this.UserChoice.Controls.Add(this.UserPicture);
            this.UserChoice.Controls.Add(this.Scissors);
            this.UserChoice.Controls.Add(this.Paper);
            this.UserChoice.Controls.Add(this.Rock);
            this.UserChoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserChoice.Location = new System.Drawing.Point(12, 10);
            this.UserChoice.Name = "UserChoice";
            this.UserChoice.Size = new System.Drawing.Size(290, 449);
            this.UserChoice.TabIndex = 0;
            this.UserChoice.TabStop = false;
            this.UserChoice.Text = "UserChoice";
            // 
            // Scissors
            // 
            this.Scissors.AutoSize = true;
            this.Scissors.Location = new System.Drawing.Point(15, 377);
            this.Scissors.Name = "Scissors";
            this.Scissors.Size = new System.Drawing.Size(87, 24);
            this.Scissors.TabIndex = 2;
            this.Scissors.TabStop = true;
            this.Scissors.Text = "Scissors";
            this.Scissors.UseVisualStyleBackColor = true;
            this.Scissors.CheckedChanged += new System.EventHandler(this.Scissors_CheckedChanged);
            // 
            // Paper
            // 
            this.Paper.AutoSize = true;
            this.Paper.Location = new System.Drawing.Point(15, 338);
            this.Paper.Name = "Paper";
            this.Paper.Size = new System.Drawing.Size(69, 24);
            this.Paper.TabIndex = 1;
            this.Paper.TabStop = true;
            this.Paper.Text = "Paper";
            this.Paper.UseVisualStyleBackColor = true;
            this.Paper.CheckedChanged += new System.EventHandler(this.Paper_CheckedChanged);
            // 
            // Rock
            // 
            this.Rock.AutoSize = true;
            this.Rock.Location = new System.Drawing.Point(15, 295);
            this.Rock.Name = "Rock";
            this.Rock.Size = new System.Drawing.Size(64, 24);
            this.Rock.TabIndex = 0;
            this.Rock.TabStop = true;
            this.Rock.Text = "Rock";
            this.Rock.UseVisualStyleBackColor = true;
            this.Rock.CheckedChanged += new System.EventHandler(this.Rock_CheckedChanged);
            // 
            // ComputerChoice
            // 
            this.ComputerChoice.Controls.Add(this.Play);
            this.ComputerChoice.Controls.Add(this.ComputerPicture);
            this.ComputerChoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComputerChoice.Location = new System.Drawing.Point(308, 10);
            this.ComputerChoice.Name = "ComputerChoice";
            this.ComputerChoice.Size = new System.Drawing.Size(290, 449);
            this.ComputerChoice.TabIndex = 1;
            this.ComputerChoice.TabStop = false;
            this.ComputerChoice.Text = "ComputerChoice";
            // 
            // Play
            // 
            this.Play.Location = new System.Drawing.Point(98, 410);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(81, 33);
            this.Play.TabIndex = 3;
            this.Play.Text = "Play";
            this.Play.UseVisualStyleBackColor = true;
            this.Play.Click += new System.EventHandler(this.Play_Click);
            // 
            // Result
            // 
            this.Result.Controls.Add(this.lblComputerScore);
            this.Result.Controls.Add(this.lblUserScore);
            this.Result.Controls.Add(this.LabelUserScore);
            this.Result.Controls.Add(this.LabelComputerScore);
            this.Result.Controls.Add(this.ResultText);
            this.Result.Controls.Add(this.Quit);
            this.Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Result.Location = new System.Drawing.Point(604, 10);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(290, 449);
            this.Result.TabIndex = 2;
            this.Result.TabStop = false;
            this.Result.Text = "Result";
            // 
            // lblComputerScore
            // 
            this.lblComputerScore.AutoSize = true;
            this.lblComputerScore.Location = new System.Drawing.Point(87, 311);
            this.lblComputerScore.Name = "lblComputerScore";
            this.lblComputerScore.Size = new System.Drawing.Size(122, 20);
            this.lblComputerScore.TabIndex = 9;
            this.lblComputerScore.Text = "Computer score";
            // 
            // lblUserScore
            // 
            this.lblUserScore.AutoSize = true;
            this.lblUserScore.Location = new System.Drawing.Point(108, 229);
            this.lblUserScore.Name = "lblUserScore";
            this.lblUserScore.Size = new System.Drawing.Size(86, 20);
            this.lblUserScore.TabIndex = 8;
            this.lblUserScore.Text = "User score";
            // 
            // LabelUserScore
            // 
            this.LabelUserScore.AutoSize = true;
            this.LabelUserScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelUserScore.Location = new System.Drawing.Point(143, 258);
            this.LabelUserScore.Name = "LabelUserScore";
            this.LabelUserScore.Size = new System.Drawing.Size(0, 31);
            this.LabelUserScore.TabIndex = 7;
            this.LabelUserScore.Click += new System.EventHandler(this.LabelUserScore_Click);
            // 
            // LabelComputerScore
            // 
            this.LabelComputerScore.AutoSize = true;
            this.LabelComputerScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelComputerScore.Location = new System.Drawing.Point(143, 331);
            this.LabelComputerScore.Name = "LabelComputerScore";
            this.LabelComputerScore.Size = new System.Drawing.Size(0, 31);
            this.LabelComputerScore.TabIndex = 6;
            this.LabelComputerScore.Click += new System.EventHandler(this.LabelComputerScore_Click);
            // 
            // ResultText
            // 
            this.ResultText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultText.Location = new System.Drawing.Point(6, 22);
            this.ResultText.Name = "ResultText";
            this.ResultText.Size = new System.Drawing.Size(278, 379);
            this.ResultText.TabIndex = 5;
            this.ResultText.Click += new System.EventHandler(this.LabelResult_Click);
            // 
            // Quit
            // 
            this.Quit.Location = new System.Drawing.Point(113, 410);
            this.Quit.Name = "Quit";
            this.Quit.Size = new System.Drawing.Size(81, 33);
            this.Quit.TabIndex = 4;
            this.Quit.Text = "Quit";
            this.Quit.UseVisualStyleBackColor = true;
            this.Quit.Click += new System.EventHandler(this.Quit_Click);
            // 
            // ComputerPicture
            // 
            this.ComputerPicture.Location = new System.Drawing.Point(26, 25);
            this.ComputerPicture.Name = "ComputerPicture";
            this.ComputerPicture.Size = new System.Drawing.Size(244, 213);
            this.ComputerPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ComputerPicture.TabIndex = 4;
            this.ComputerPicture.TabStop = false;
            this.ComputerPicture.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // UserPicture
            // 
            this.UserPicture.Location = new System.Drawing.Point(15, 25);
            this.UserPicture.Name = "UserPicture";
            this.UserPicture.Size = new System.Drawing.Size(244, 213);
            this.UserPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.UserPicture.TabIndex = 3;
            this.UserPicture.TabStop = false;
            this.UserPicture.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // RPSGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(923, 580);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.ComputerChoice);
            this.Controls.Add(this.UserChoice);
            this.Name = "RPSGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rock Paper Scissors Game";
            this.Load += new System.EventHandler(this.RPSGame_Load);
            this.UserChoice.ResumeLayout(false);
            this.UserChoice.PerformLayout();
            this.ComputerChoice.ResumeLayout(false);
            this.ComputerChoice.PerformLayout();
            this.Result.ResumeLayout(false);
            this.Result.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ComputerPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox UserChoice;
        private System.Windows.Forms.PictureBox UserPicture;
        private System.Windows.Forms.RadioButton Scissors;
        private System.Windows.Forms.RadioButton Paper;
        private System.Windows.Forms.RadioButton Rock;
        private System.Windows.Forms.GroupBox ComputerChoice;
        private System.Windows.Forms.Button Play;
        private System.Windows.Forms.PictureBox ComputerPicture;
        private System.Windows.Forms.GroupBox Result;
        private System.Windows.Forms.Label ResultText;
        private System.Windows.Forms.Button Quit;
        private System.Windows.Forms.Label lblComputerScore;
        private System.Windows.Forms.Label lblUserScore;
        private System.Windows.Forms.Label LabelUserScore;
        private System.Windows.Forms.Label LabelComputerScore;
    }
}