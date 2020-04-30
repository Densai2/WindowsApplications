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
            this.BestComputer = new System.Windows.Forms.Button();
            this.BestSoftware = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Greeting
            // 
            this.Greeting.BackColor = System.Drawing.Color.Yellow;
            this.Greeting.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Greeting.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Greeting.ForeColor = System.Drawing.Color.Blue;
            this.Greeting.Location = new System.Drawing.Point(190, 31);
            this.Greeting.Name = "Greeting";
            this.Greeting.Size = new System.Drawing.Size(370, 40);
            this.Greeting.TabIndex = 0;
            this.Greeting.Text = "Welcome to SuperSoft";
            this.Greeting.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Brag
            // 
            this.Brag.BackColor = System.Drawing.Color.Yellow;
            this.Brag.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Brag.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Brag.ForeColor = System.Drawing.Color.Blue;
            this.Brag.Location = new System.Drawing.Point(219, 147);
            this.Brag.Name = "Brag";
            this.Brag.Size = new System.Drawing.Size(310, 70);
            this.Brag.TabIndex = 1;
            this.Brag.Text = "The BEST prices";
            this.Brag.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Quit
            // 
            this.Quit.Location = new System.Drawing.Point(682, 365);
            this.Quit.Name = "Quit";
            this.Quit.Size = new System.Drawing.Size(75, 23);
            this.Quit.TabIndex = 2;
            this.Quit.Text = "Quit";
            this.Quit.UseVisualStyleBackColor = true;
            this.Quit.Click += new System.EventHandler(this.Exit);
            // 
            // BestComputer
            // 
            this.BestComputer.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BestComputer.Location = new System.Drawing.Point(219, 320);
            this.BestComputer.Name = "BestComputer";
            this.BestComputer.Size = new System.Drawing.Size(138, 45);
            this.BestComputer.TabIndex = 3;
            this.BestComputer.Text = "Best Computer";
            this.BestComputer.UseVisualStyleBackColor = false;
            this.BestComputer.Click += new System.EventHandler(this.BestComputer_Click);
            // 
            // BestSoftware
            // 
            this.BestSoftware.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BestSoftware.Location = new System.Drawing.Point(391, 320);
            this.BestSoftware.Name = "BestSoftware";
            this.BestSoftware.Size = new System.Drawing.Size(138, 45);
            this.BestSoftware.TabIndex = 4;
            this.BestSoftware.Text = "Best Software";
            this.BestSoftware.UseVisualStyleBackColor = false;
            this.BestSoftware.Click += new System.EventHandler(this.BestSoftware_Click);
            // 
            // LabelControls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(763, 394);
            this.Controls.Add(this.BestSoftware);
            this.Controls.Add(this.BestComputer);
            this.Controls.Add(this.Quit);
            this.Controls.Add(this.Brag);
            this.Controls.Add(this.Greeting);
            this.ForeColor = System.Drawing.SystemColors.GrayText;
            this.Name = "LabelControls";
            this.Text = "LabelControls";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Greeting;
        private System.Windows.Forms.Label Brag;
        private System.Windows.Forms.Button Quit;
        private System.Windows.Forms.Button BestComputer;
        private System.Windows.Forms.Button BestSoftware;
    }
}