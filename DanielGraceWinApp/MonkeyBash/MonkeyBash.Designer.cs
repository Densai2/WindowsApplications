namespace DanielGraceWinApp.MonkeyBash
{
    partial class MonkeyBash
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
            this.components = new System.ComponentModel.Container();
            this.Start = new System.Windows.Forms.Button();
            this.Stop = new System.Windows.Forms.Button();
            this.Quit = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.TotalHits = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.Pannel = new System.Windows.Forms.Panel();
            this.MonkeyFour = new System.Windows.Forms.PictureBox();
            this.MonkeyThree = new System.Windows.Forms.PictureBox();
            this.MonkeyTwo = new System.Windows.Forms.PictureBox();
            this.MonkeyOne = new System.Windows.Forms.PictureBox();
            this.Pannel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MonkeyFour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MonkeyThree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MonkeyTwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MonkeyOne)).BeginInit();
            this.SuspendLayout();
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(30, 415);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(75, 23);
            this.Start.TabIndex = 0;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Begin);
            // 
            // Stop
            // 
            this.Stop.Location = new System.Drawing.Point(138, 415);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(75, 23);
            this.Stop.TabIndex = 1;
            this.Stop.Text = "Stop";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Finish);
            // 
            // Quit
            // 
            this.Quit.Location = new System.Drawing.Point(254, 415);
            this.Quit.Name = "Quit";
            this.Quit.Size = new System.Drawing.Size(75, 23);
            this.Quit.TabIndex = 2;
            this.Quit.Text = "Quit";
            this.Quit.UseVisualStyleBackColor = true;
            this.Quit.Click += new System.EventHandler(this.Exit);
            // 
            // timer1
            // 
            this.timer1.Interval = 600;
            this.timer1.Tick += new System.EventHandler(this.TimerOne);
            // 
            // TotalHits
            // 
            this.TotalHits.AutoSize = true;
            this.TotalHits.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalHits.Location = new System.Drawing.Point(530, 415);
            this.TotalHits.Name = "TotalHits";
            this.TotalHits.Size = new System.Drawing.Size(0, 25);
            this.TotalHits.TabIndex = 5;
            // 
            // timer2
            // 
            this.timer2.Interval = 200;
            this.timer2.Tick += new System.EventHandler(this.TimerTwo);
            // 
            // timer3
            // 
            this.timer3.Interval = 600;
            this.timer3.Tick += new System.EventHandler(this.TimerThree);
            // 
            // timer4
            // 
            this.timer4.Interval = 750;
            this.timer4.Tick += new System.EventHandler(this.TimerFour);
            // 
            // Pannel
            // 
            this.Pannel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Pannel.Controls.Add(this.MonkeyFour);
            this.Pannel.Controls.Add(this.MonkeyThree);
            this.Pannel.Controls.Add(this.MonkeyTwo);
            this.Pannel.Controls.Add(this.MonkeyOne);
            this.Pannel.Location = new System.Drawing.Point(0, 0);
            this.Pannel.Name = "Pannel";
            this.Pannel.Size = new System.Drawing.Size(798, 409);
            this.Pannel.TabIndex = 6;
            this.Pannel.Click += new System.EventHandler(this.PanelMiss);
            // 
            // MonkeyFour
            // 
            this.MonkeyFour.BackColor = System.Drawing.Color.Transparent;
            this.MonkeyFour.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MonkeyFour.Image = global::DanielGraceWinApp.Properties.Resources.monkey_png_transparent_images_png_only_61;
            this.MonkeyFour.Location = new System.Drawing.Point(76, 98);
            this.MonkeyFour.Name = "MonkeyFour";
            this.MonkeyFour.Size = new System.Drawing.Size(100, 100);
            this.MonkeyFour.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MonkeyFour.TabIndex = 6;
            this.MonkeyFour.TabStop = false;
            this.MonkeyFour.Click += new System.EventHandler(this.Monkey_Four);
            // 
            // MonkeyThree
            // 
            this.MonkeyThree.BackColor = System.Drawing.Color.Transparent;
            this.MonkeyThree.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MonkeyThree.Image = global::DanielGraceWinApp.Properties.Resources.monkey_png_transparent_images_png_only_61;
            this.MonkeyThree.Location = new System.Drawing.Point(254, 229);
            this.MonkeyThree.Name = "MonkeyThree";
            this.MonkeyThree.Size = new System.Drawing.Size(100, 100);
            this.MonkeyThree.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MonkeyThree.TabIndex = 5;
            this.MonkeyThree.TabStop = false;
            this.MonkeyThree.Click += new System.EventHandler(this.Monkey_Three);
            // 
            // MonkeyTwo
            // 
            this.MonkeyTwo.BackColor = System.Drawing.Color.Transparent;
            this.MonkeyTwo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.MonkeyTwo.Image = global::DanielGraceWinApp.Properties.Resources.monkey_png_transparent_images_png_only_61;
            this.MonkeyTwo.Location = new System.Drawing.Point(521, 181);
            this.MonkeyTwo.Name = "MonkeyTwo";
            this.MonkeyTwo.Size = new System.Drawing.Size(100, 100);
            this.MonkeyTwo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MonkeyTwo.TabIndex = 4;
            this.MonkeyTwo.TabStop = false;
            this.MonkeyTwo.Click += new System.EventHandler(this.Monkey_Two);
            // 
            // MonkeyOne
            // 
            this.MonkeyOne.BackColor = System.Drawing.Color.Transparent;
            this.MonkeyOne.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MonkeyOne.Image = global::DanielGraceWinApp.Properties.Resources.monkey_png_transparent_images_png_only_61;
            this.MonkeyOne.Location = new System.Drawing.Point(352, 38);
            this.MonkeyOne.Name = "MonkeyOne";
            this.MonkeyOne.Size = new System.Drawing.Size(100, 100);
            this.MonkeyOne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MonkeyOne.TabIndex = 3;
            this.MonkeyOne.TabStop = false;
            this.MonkeyOne.Click += new System.EventHandler(this.Monkey_One);
            // 
            // MonkeyBash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Pannel);
            this.Controls.Add(this.TotalHits);
            this.Controls.Add(this.Quit);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.Start);
            this.Name = "MonkeyBash";
            this.Text = "MonkeyBash";
            this.Pannel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MonkeyFour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MonkeyThree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MonkeyTwo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MonkeyOne)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.Button Quit;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label TotalHits;
        private System.Windows.Forms.PictureBox MonkeyOne;
        private System.Windows.Forms.Panel Pannel;
        private System.Windows.Forms.PictureBox MonkeyTwo;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.PictureBox MonkeyFour;
        private System.Windows.Forms.PictureBox MonkeyThree;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
    }
}