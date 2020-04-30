namespace DanielGraceWinApp.TargetPractice
{
    partial class TargetPractice
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
            this.ButtonStart = new System.Windows.Forms.Button();
            this.ButtonStop = new System.Windows.Forms.Button();
            this.ButtonQuit = new System.Windows.Forms.Button();
            this.Pannel = new System.Windows.Forms.Panel();
            this.PictureTarget = new System.Windows.Forms.PictureBox();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.LabelTotalHits = new System.Windows.Forms.Label();
            this.LabelScore = new System.Windows.Forms.Label();
            this.Pannel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureTarget)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonStart
            // 
            this.ButtonStart.Location = new System.Drawing.Point(57, 414);
            this.ButtonStart.Name = "ButtonStart";
            this.ButtonStart.Size = new System.Drawing.Size(92, 24);
            this.ButtonStart.TabIndex = 0;
            this.ButtonStart.Text = "Start";
            this.ButtonStart.UseVisualStyleBackColor = true;
            this.ButtonStart.Click += new System.EventHandler(this.Start);
            // 
            // ButtonStop
            // 
            this.ButtonStop.Location = new System.Drawing.Point(176, 414);
            this.ButtonStop.Name = "ButtonStop";
            this.ButtonStop.Size = new System.Drawing.Size(92, 24);
            this.ButtonStop.TabIndex = 1;
            this.ButtonStop.Text = "Stop";
            this.ButtonStop.UseVisualStyleBackColor = true;
            this.ButtonStop.Click += new System.EventHandler(this.Stop);
            // 
            // ButtonQuit
            // 
            this.ButtonQuit.Location = new System.Drawing.Point(295, 414);
            this.ButtonQuit.Name = "ButtonQuit";
            this.ButtonQuit.Size = new System.Drawing.Size(92, 24);
            this.ButtonQuit.TabIndex = 2;
            this.ButtonQuit.Text = "Quit";
            this.ButtonQuit.UseVisualStyleBackColor = true;
            this.ButtonQuit.Click += new System.EventHandler(this.Close);
            // 
            // Pannel
            // 
            this.Pannel.Controls.Add(this.PictureTarget);
            this.Pannel.Location = new System.Drawing.Point(0, 0);
            this.Pannel.Name = "Pannel";
            this.Pannel.Size = new System.Drawing.Size(800, 408);
            this.Pannel.TabIndex = 3;
            this.Pannel.Click += new System.EventHandler(this.BackPannel);
            // 
            // PictureTarget
            // 
            this.PictureTarget.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PictureTarget.Image = global::DanielGraceWinApp.Properties.Resources.unnamed__1_;
            this.PictureTarget.ImageLocation = "";
            this.PictureTarget.Location = new System.Drawing.Point(274, 62);
            this.PictureTarget.Name = "PictureTarget";
            this.PictureTarget.Size = new System.Drawing.Size(100, 100);
            this.PictureTarget.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureTarget.TabIndex = 0;
            this.PictureTarget.TabStop = false;
            this.PictureTarget.Click += new System.EventHandler(this.Target);
            this.PictureTarget.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MouseMovement);
            // 
            // Timer1
            // 
            this.Timer1.Interval = 1000;
            this.Timer1.Tick += new System.EventHandler(this.TimerOne);
            // 
            // LabelTotalHits
            // 
            this.LabelTotalHits.AutoSize = true;
            this.LabelTotalHits.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTotalHits.Location = new System.Drawing.Point(418, 414);
            this.LabelTotalHits.Name = "LabelTotalHits";
            this.LabelTotalHits.Size = new System.Drawing.Size(0, 31);
            this.LabelTotalHits.TabIndex = 4;
            // 
            // LabelScore
            // 
            this.LabelScore.AutoSize = true;
            this.LabelScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelScore.Location = new System.Drawing.Point(689, 414);
            this.LabelScore.Name = "LabelScore";
            this.LabelScore.Size = new System.Drawing.Size(0, 31);
            this.LabelScore.TabIndex = 5;
            // 
            // TargetPractice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LabelScore);
            this.Controls.Add(this.LabelTotalHits);
            this.Controls.Add(this.Pannel);
            this.Controls.Add(this.ButtonQuit);
            this.Controls.Add(this.ButtonStop);
            this.Controls.Add(this.ButtonStart);
            this.Name = "TargetPractice";
            this.Text = "TargetPractice";
            this.Pannel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureTarget)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonStart;
        private System.Windows.Forms.Button ButtonStop;
        private System.Windows.Forms.Button ButtonQuit;
        private System.Windows.Forms.Panel Pannel;
        private System.Windows.Forms.PictureBox PictureTarget;
        private System.Windows.Forms.Timer Timer1;
        private System.Windows.Forms.Label LabelTotalHits;
        private System.Windows.Forms.Label LabelScore;
    }
}