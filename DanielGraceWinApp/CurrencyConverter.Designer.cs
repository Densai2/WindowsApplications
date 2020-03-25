namespace DanielGraceWinApp
{
    partial class CurrencyConverter
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblUKPounds = new System.Windows.Forms.Label();
            this.lblConvertedAmount = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioDollars = new System.Windows.Forms.RadioButton();
            this.radioEuros = new System.Windows.Forms.RadioButton();
            this.radioRupees = new System.Windows.Forms.RadioButton();
            this.UKPounds = new System.Windows.Forms.TextBox();
            this.ConvertedAmount = new System.Windows.Forms.TextBox();
            this.Line = new System.Windows.Forms.Label();
            this.Quit = new System.Windows.Forms.Button();
            this.EndAmount = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(106, 42);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(359, 46);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Currency converter";
            // 
            // lblUKPounds
            // 
            this.lblUKPounds.AutoSize = true;
            this.lblUKPounds.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUKPounds.Location = new System.Drawing.Point(140, 159);
            this.lblUKPounds.Name = "lblUKPounds";
            this.lblUKPounds.Size = new System.Drawing.Size(112, 25);
            this.lblUKPounds.TabIndex = 1;
            this.lblUKPounds.Text = "UK Pounds";
            // 
            // lblConvertedAmount
            // 
            this.lblConvertedAmount.AutoSize = true;
            this.lblConvertedAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConvertedAmount.Location = new System.Drawing.Point(140, 247);
            this.lblConvertedAmount.Name = "lblConvertedAmount";
            this.lblConvertedAmount.Size = new System.Drawing.Size(173, 25);
            this.lblConvertedAmount.TabIndex = 2;
            this.lblConvertedAmount.Text = "Converted amount";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Quit);
            this.groupBox1.Controls.Add(this.radioRupees);
            this.groupBox1.Controls.Add(this.radioEuros);
            this.groupBox1.Controls.Add(this.radioDollars);
            this.groupBox1.Location = new System.Drawing.Point(532, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(206, 318);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // radioDollars
            // 
            this.radioDollars.AutoSize = true;
            this.radioDollars.Location = new System.Drawing.Point(70, 41);
            this.radioDollars.Name = "radioDollars";
            this.radioDollars.Size = new System.Drawing.Size(57, 17);
            this.radioDollars.TabIndex = 0;
            this.radioDollars.TabStop = true;
            this.radioDollars.Text = "Dollars";
            this.radioDollars.UseVisualStyleBackColor = true;
            this.radioDollars.CheckedChanged += new System.EventHandler(this.radioDollars_CheckedChanged);
            // 
            // radioEuros
            // 
            this.radioEuros.AutoSize = true;
            this.radioEuros.Location = new System.Drawing.Point(70, 97);
            this.radioEuros.Name = "radioEuros";
            this.radioEuros.Size = new System.Drawing.Size(52, 17);
            this.radioEuros.TabIndex = 1;
            this.radioEuros.TabStop = true;
            this.radioEuros.Text = "Euros";
            this.radioEuros.UseVisualStyleBackColor = true;
            this.radioEuros.CheckedChanged += new System.EventHandler(this.radioEuros_CheckedChanged);
            // 
            // radioRupees
            // 
            this.radioRupees.AutoSize = true;
            this.radioRupees.Location = new System.Drawing.Point(70, 159);
            this.radioRupees.Name = "radioRupees";
            this.radioRupees.Size = new System.Drawing.Size(62, 17);
            this.radioRupees.TabIndex = 2;
            this.radioRupees.TabStop = true;
            this.radioRupees.Text = "Rupees";
            this.radioRupees.UseVisualStyleBackColor = true;
            this.radioRupees.CheckedChanged += new System.EventHandler(this.radioRupees_CheckedChanged);
            // 
            // UKPounds
            // 
            this.UKPounds.Location = new System.Drawing.Point(281, 159);
            this.UKPounds.Name = "UKPounds";
            this.UKPounds.Size = new System.Drawing.Size(150, 20);
            this.UKPounds.TabIndex = 4;
            this.UKPounds.Text = "0";
            this.UKPounds.TextChanged += new System.EventHandler(this.UKPounds_TextChanged);
            // 
            // ConvertedAmount
            // 
            this.ConvertedAmount.Location = new System.Drawing.Point(333, 252);
            this.ConvertedAmount.Name = "ConvertedAmount";
            this.ConvertedAmount.Size = new System.Drawing.Size(150, 20);
            this.ConvertedAmount.TabIndex = 5;
            this.ConvertedAmount.TextChanged += new System.EventHandler(this.ConvertedAmount_TextChanged);
            // 
            // Line
            // 
            this.Line.AutoSize = true;
            this.Line.BackColor = System.Drawing.Color.Black;
            this.Line.Location = new System.Drawing.Point(162, 88);
            this.Line.Name = "Line";
            this.Line.Size = new System.Drawing.Size(250, 13);
            this.Line.TabIndex = 6;
            this.Line.Text = "                                                                                 " +
    "";
            // 
            // Quit
            // 
            this.Quit.Location = new System.Drawing.Point(70, 227);
            this.Quit.Name = "Quit";
            this.Quit.Size = new System.Drawing.Size(75, 23);
            this.Quit.TabIndex = 3;
            this.Quit.Text = "Quit";
            this.Quit.UseVisualStyleBackColor = true;
            this.Quit.Click += new System.EventHandler(this.button1_Click);
            // 
            // EndAmount
            // 
            this.EndAmount.AutoSize = true;
            this.EndAmount.Location = new System.Drawing.Point(340, 256);
            this.EndAmount.Name = "EndAmount";
            this.EndAmount.Size = new System.Drawing.Size(0, 13);
            this.EndAmount.TabIndex = 7;
            // 
            // CurrencyConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EndAmount);
            this.Controls.Add(this.Line);
            this.Controls.Add(this.ConvertedAmount);
            this.Controls.Add(this.UKPounds);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblConvertedAmount);
            this.Controls.Add(this.lblUKPounds);
            this.Controls.Add(this.lblTitle);
            this.Name = "CurrencyConverter";
            this.Text = "Convert pounds to foreign currency";
            this.Load += new System.EventHandler(this.CurrencyConverter_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblUKPounds;
        private System.Windows.Forms.Label lblConvertedAmount;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Quit;
        private System.Windows.Forms.RadioButton radioRupees;
        private System.Windows.Forms.RadioButton radioEuros;
        private System.Windows.Forms.RadioButton radioDollars;
        private System.Windows.Forms.TextBox UKPounds;
        private System.Windows.Forms.TextBox ConvertedAmount;
        private System.Windows.Forms.Label Line;
        private System.Windows.Forms.Label EndAmount;
    }
}