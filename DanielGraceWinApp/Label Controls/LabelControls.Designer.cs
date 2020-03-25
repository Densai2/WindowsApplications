namespace DataEntryForm
{
    partial class LabelControls
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
            this.Greeting = new System.Windows.Forms.Label();
            this.Brag = new System.Windows.Forms.Label();
            this.Quit = new System.Windows.Forms.Button();
            this.ComputerText = new System.Windows.Forms.Label();
            this.SoftwareText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Greeting
            // 
            this.Greeting.BackColor = System.Drawing.Color.Yellow;
            this.Greeting.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Greeting.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Greeting.ForeColor = System.Drawing.Color.Blue;
            this.Greeting.Location = new System.Drawing.Point(100, 30);
            this.Greeting.Name = "Greeting";
            this.Greeting.Size = new System.Drawing.Size(370, 40);
            this.Greeting.TabIndex = 0;
            this.Greeting.Text = "Welcome to SuperSoft";
            this.Greeting.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Greeting.Click += new System.EventHandler(this.Greeting_Click);
            // 
            // Brag
            // 
            this.Brag.BackColor = System.Drawing.Color.Yellow;
            this.Brag.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Brag.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Brag.ForeColor = System.Drawing.Color.Blue;
            this.Brag.Location = new System.Drawing.Point(100, 90);
            this.Brag.Name = "Brag";
            this.Brag.Size = new System.Drawing.Size(310, 70);
            this.Brag.TabIndex = 1;
            this.Brag.Text = "The BEST prices";
            this.Brag.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Brag.Click += new System.EventHandler(this.BragText);
            // 
            // Quit
            // 
            this.Quit.Location = new System.Drawing.Point(682, 365);
            this.Quit.Name = "Quit";
            this.Quit.Size = new System.Drawing.Size(75, 23);
            this.Quit.TabIndex = 2;
            this.Quit.Text = "Quit";
            this.Quit.UseVisualStyleBackColor = true;
            this.Quit.Click += new System.EventHandler(this.Quit_Click);
            // 
            // ComputerText
            // 
            this.ComputerText.BackColor = System.Drawing.Color.Yellow;
            this.ComputerText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ComputerText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComputerText.ForeColor = System.Drawing.Color.Blue;
            this.ComputerText.Location = new System.Drawing.Point(100, 212);
            this.ComputerText.Name = "ComputerText";
            this.ComputerText.Size = new System.Drawing.Size(267, 92);
            this.ComputerText.TabIndex = 3;
            this.ComputerText.Text = "Best Computer";
            this.ComputerText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ComputerText.Click += new System.EventHandler(this.BestComputerText);
            // 
            // SoftwareText
            // 
            this.SoftwareText.BackColor = System.Drawing.Color.Yellow;
            this.SoftwareText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SoftwareText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SoftwareText.ForeColor = System.Drawing.Color.Blue;
            this.SoftwareText.Location = new System.Drawing.Point(373, 212);
            this.SoftwareText.Name = "SoftwareText";
            this.SoftwareText.Size = new System.Drawing.Size(269, 92);
            this.SoftwareText.TabIndex = 4;
            this.SoftwareText.Text = "Best Software";
            this.SoftwareText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SoftwareText.Click += new System.EventHandler(this.BestSoftware);
            // 
            // LabelControls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(763, 394);
            this.Controls.Add(this.SoftwareText);
            this.Controls.Add(this.ComputerText);
            this.Controls.Add(this.Quit);
            this.Controls.Add(this.Brag);
            this.Controls.Add(this.Greeting);
            this.ForeColor = System.Drawing.SystemColors.GrayText;
            this.Name = "LabelControls";
            this.Text = "LabelControls";
            this.Load += new System.EventHandler(this.LabelControls_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Greeting;
        private System.Windows.Forms.Label Brag;
        private System.Windows.Forms.Button Quit;
        private System.Windows.Forms.Label ComputerText;
        private System.Windows.Forms.Label SoftwareText;
    }
}