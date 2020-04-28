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
            this.UserPicture = new System.Windows.Forms.PictureBox();
            this.Scissors = new System.Windows.Forms.RadioButton();
            this.Paper = new System.Windows.Forms.RadioButton();
            this.Rock = new System.Windows.Forms.RadioButton();
            this.ComputerChoice = new System.Windows.Forms.GroupBox();
            this.Play = new System.Windows.Forms.Button();
            this.ComputerPicture = new System.Windows.Forms.PictureBox();
            this.Result = new System.Windows.Forms.GroupBox();
            this.TextComputerScore = new System.Windows.Forms.Label();
            this.TextUserScore = new System.Windows.Forms.Label();
            this.LabelUserScore = new System.Windows.Forms.Label();
            this.LabelComputerScore = new System.Windows.Forms.Label();
            this.ResultText = new System.Windows.Forms.Label();
            this.Quit = new System.Windows.Forms.Button();
            this.UserChoice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserPicture)).BeginInit();
            this.ComputerChoice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ComputerPicture)).BeginInit();
            this.Result.SuspendLayout();
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
            // UserPicture
            // 
            this.UserPicture.Location = new System.Drawing.Point(15, 25);
            this.UserPicture.Name = "UserPicture";
            this.UserPicture.Size = new System.Drawing.Size(244, 213);
            this.UserPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.UserPicture.TabIndex = 3;
            this.UserPicture.TabStop = false;
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
            this.Scissors.CheckedChanged += new System.EventHandler(this.UserScissors);
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
            this.Paper.CheckedChanged += new System.EventHandler(this.UserPaper);
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
            this.Rock.CheckedChanged += new System.EventHandler(this.UserRock);
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
            // ComputerPicture
            // 
            this.ComputerPicture.Location = new System.Drawing.Point(26, 25);
            this.ComputerPicture.Name = "ComputerPicture";
            this.ComputerPicture.Size = new System.Drawing.Size(244, 213);
            this.ComputerPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ComputerPicture.TabIndex = 4;
            this.ComputerPicture.TabStop = false;
            // 
            // Result
            // 
            this.Result.Controls.Add(this.TextComputerScore);
            this.Result.Controls.Add(this.TextUserScore);
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
            // TextComputerScore
            // 
            this.TextComputerScore.AutoSize = true;
            this.TextComputerScore.Location = new System.Drawing.Point(87, 311);
            this.TextComputerScore.Name = "TextComputerScore";
            this.TextComputerScore.Size = new System.Drawing.Size(122, 20);
            this.TextComputerScore.TabIndex = 9;
            this.TextComputerScore.Text = "Computer score";
            // 
            // TextUserScore
            // 
            this.TextUserScore.AutoSize = true;
            this.TextUserScore.Location = new System.Drawing.Point(108, 229);
            this.TextUserScore.Name = "TextUserScore";
            this.TextUserScore.Size = new System.Drawing.Size(86, 20);
            this.TextUserScore.TabIndex = 8;
            this.TextUserScore.Text = "User score";
            // 
            // LabelUserScore
            // 
            this.LabelUserScore.AutoSize = true;
            this.LabelUserScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelUserScore.Location = new System.Drawing.Point(143, 258);
            this.LabelUserScore.Name = "LabelUserScore";
            this.LabelUserScore.Size = new System.Drawing.Size(0, 31);
            this.LabelUserScore.TabIndex = 7;
            this.LabelUserScore.Click += new System.EventHandler(this.PlayerScore);
            // 
            // LabelComputerScore
            // 
            this.LabelComputerScore.AutoSize = true;
            this.LabelComputerScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelComputerScore.Location = new System.Drawing.Point(143, 331);
            this.LabelComputerScore.Name = "LabelComputerScore";
            this.LabelComputerScore.Size = new System.Drawing.Size(0, 31);
            this.LabelComputerScore.TabIndex = 6;
            // 
            // ResultText
            // 
            this.ResultText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultText.Location = new System.Drawing.Point(6, 22);
            this.ResultText.Name = "ResultText";
            this.ResultText.Size = new System.Drawing.Size(278, 379);
            this.ResultText.TabIndex = 5;
            // 
            // Quit
            // 
            this.Quit.Location = new System.Drawing.Point(113, 410);
            this.Quit.Name = "Quit";
            this.Quit.Size = new System.Drawing.Size(81, 33);
            this.Quit.TabIndex = 4;
            this.Quit.Text = "Quit";
            this.Quit.UseVisualStyleBackColor = true;
            this.Quit.Click += new System.EventHandler(this.Exit);
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
            ((System.ComponentModel.ISupportInitialize)(this.UserPicture)).EndInit();
            this.ComputerChoice.ResumeLayout(false);
            this.ComputerChoice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ComputerPicture)).EndInit();
            this.Result.ResumeLayout(false);
            this.Result.PerformLayout();
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
        private System.Windows.Forms.Label TextComputerScore;
        private System.Windows.Forms.Label TextUserScore;
        private System.Windows.Forms.Label LabelUserScore;
        private System.Windows.Forms.Label LabelComputerScore;
    }
}