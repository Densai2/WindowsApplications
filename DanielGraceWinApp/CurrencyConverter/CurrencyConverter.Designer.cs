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
            this.LabelTitle = new System.Windows.Forms.Label();
            this.LabelPounds = new System.Windows.Forms.Label();
            this.LabelCoverted = new System.Windows.Forms.Label();
            this.GroupBox = new System.Windows.Forms.GroupBox();
            this.Quit = new System.Windows.Forms.Button();
            this.RadioRupees = new System.Windows.Forms.RadioButton();
            this.RadioEuros = new System.Windows.Forms.RadioButton();
            this.RadioDollars = new System.Windows.Forms.RadioButton();
            this.UKPounds = new System.Windows.Forms.TextBox();
            this.ConvertedAmount = new System.Windows.Forms.TextBox();
            this.Line = new System.Windows.Forms.Label();
            this.EndAmount = new System.Windows.Forms.Label();
            this.GroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // LabelTitle
            // 
            this.LabelTitle.AutoSize = true;
            this.LabelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTitle.Location = new System.Drawing.Point(106, 42);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(359, 46);
            this.LabelTitle.TabIndex = 0;
            this.LabelTitle.Text = "Currency converter";
            // 
            // LabelPounds
            // 
            this.LabelPounds.AutoSize = true;
            this.LabelPounds.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPounds.Location = new System.Drawing.Point(140, 159);
            this.LabelPounds.Name = "LabelPounds";
            this.LabelPounds.Size = new System.Drawing.Size(112, 25);
            this.LabelPounds.TabIndex = 1;
            this.LabelPounds.Text = "UK Pounds";
            // 
            // LabelCoverted
            // 
            this.LabelCoverted.AutoSize = true;
            this.LabelCoverted.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCoverted.Location = new System.Drawing.Point(140, 247);
            this.LabelCoverted.Name = "LabelCoverted";
            this.LabelCoverted.Size = new System.Drawing.Size(173, 25);
            this.LabelCoverted.TabIndex = 2;
            this.LabelCoverted.Text = "Converted amount";
            // 
            // GroupBox
            // 
            this.GroupBox.Controls.Add(this.Quit);
            this.GroupBox.Controls.Add(this.RadioRupees);
            this.GroupBox.Controls.Add(this.RadioEuros);
            this.GroupBox.Controls.Add(this.RadioDollars);
            this.GroupBox.Location = new System.Drawing.Point(532, 88);
            this.GroupBox.Name = "GroupBox";
            this.GroupBox.Size = new System.Drawing.Size(206, 318);
            this.GroupBox.TabIndex = 3;
            this.GroupBox.TabStop = false;
            // 
            // Quit
            // 
            this.Quit.Location = new System.Drawing.Point(70, 227);
            this.Quit.Name = "Quit";
            this.Quit.Size = new System.Drawing.Size(75, 23);
            this.Quit.TabIndex = 3;
            this.Quit.Text = "Quit";
            this.Quit.UseVisualStyleBackColor = true;
            this.Quit.Click += new System.EventHandler(this.Confirmation);
            // 
            // RadioRupees
            // 
            this.RadioRupees.AutoSize = true;
            this.RadioRupees.Location = new System.Drawing.Point(70, 159);
            this.RadioRupees.Name = "RadioRupees";
            this.RadioRupees.Size = new System.Drawing.Size(62, 17);
            this.RadioRupees.TabIndex = 2;
            this.RadioRupees.TabStop = true;
            this.RadioRupees.Text = "Rupees";
            this.RadioRupees.UseVisualStyleBackColor = true;
            this.RadioRupees.CheckedChanged += new System.EventHandler(this.Ruppes);
            // 
            // RadioEuros
            // 
            this.RadioEuros.AutoSize = true;
            this.RadioEuros.Location = new System.Drawing.Point(70, 97);
            this.RadioEuros.Name = "RadioEuros";
            this.RadioEuros.Size = new System.Drawing.Size(52, 17);
            this.RadioEuros.TabIndex = 1;
            this.RadioEuros.TabStop = true;
            this.RadioEuros.Text = "Euros";
            this.RadioEuros.UseVisualStyleBackColor = true;
            this.RadioEuros.CheckedChanged += new System.EventHandler(this.Euros);
            // 
            // RadioDollars
            // 
            this.RadioDollars.AutoSize = true;
            this.RadioDollars.Location = new System.Drawing.Point(70, 41);
            this.RadioDollars.Name = "RadioDollars";
            this.RadioDollars.Size = new System.Drawing.Size(57, 17);
            this.RadioDollars.TabIndex = 0;
            this.RadioDollars.TabStop = true;
            this.RadioDollars.Text = "Dollars";
            this.RadioDollars.UseVisualStyleBackColor = true;
            this.RadioDollars.CheckedChanged += new System.EventHandler(this.Dolars);
            // 
            // UKPounds
            // 
            this.UKPounds.Location = new System.Drawing.Point(281, 159);
            this.UKPounds.Name = "UKPounds";
            this.UKPounds.Size = new System.Drawing.Size(150, 20);
            this.UKPounds.TabIndex = 4;
            this.UKPounds.Text = "0";
            // 
            // ConvertedAmount
            // 
            this.ConvertedAmount.Location = new System.Drawing.Point(333, 252);
            this.ConvertedAmount.Name = "ConvertedAmount";
            this.ConvertedAmount.Size = new System.Drawing.Size(150, 20);
            this.ConvertedAmount.TabIndex = 5;
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
            this.Controls.Add(this.GroupBox);
            this.Controls.Add(this.LabelCoverted);
            this.Controls.Add(this.LabelPounds);
            this.Controls.Add(this.LabelTitle);
            this.Name = "CurrencyConverter";
            this.Text = "Convert pounds to foreign currency";
            this.GroupBox.ResumeLayout(false);
            this.GroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelTitle;
        private System.Windows.Forms.Label LabelPounds;
        private System.Windows.Forms.Label LabelCoverted;
        private System.Windows.Forms.GroupBox GroupBox;
        private System.Windows.Forms.Button Quit;
        private System.Windows.Forms.RadioButton RadioRupees;
        private System.Windows.Forms.RadioButton RadioEuros;
        private System.Windows.Forms.RadioButton RadioDollars;
        private System.Windows.Forms.TextBox UKPounds;
        private System.Windows.Forms.TextBox ConvertedAmount;
        private System.Windows.Forms.Label Line;
        private System.Windows.Forms.Label EndAmount;
    }
}