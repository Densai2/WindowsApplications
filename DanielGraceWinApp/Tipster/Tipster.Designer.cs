namespace DanielGraceWinApp.Tipster
{
    partial class Tipster
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
            this.Bill = new System.Windows.Forms.TextBox();
            this.NumberPeople = new System.Windows.Forms.ListBox();
            this.Calculate = new System.Windows.Forms.Button();
            this.Quit = new System.Windows.Forms.Button();
            this.LabelBill = new System.Windows.Forms.Label();
            this.LabelPeople = new System.Windows.Forms.Label();
            this.GroupTip = new System.Windows.Forms.GroupBox();
            this.RadioMad = new System.Windows.Forms.RadioButton();
            this.RadioGenerous = new System.Windows.Forms.RadioButton();
            this.RadioNormal = new System.Windows.Forms.RadioButton();
            this.RadioNone = new System.Windows.Forms.RadioButton();
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.GroupTip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Bill
            // 
            this.Bill.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bill.Location = new System.Drawing.Point(88, 65);
            this.Bill.Name = "Bill";
            this.Bill.Size = new System.Drawing.Size(204, 30);
            this.Bill.TabIndex = 0;
            // 
            // NumberPeople
            // 
            this.NumberPeople.FormattingEnabled = true;
            this.NumberPeople.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.NumberPeople.Location = new System.Drawing.Point(201, 268);
            this.NumberPeople.Name = "NumberPeople";
            this.NumberPeople.Size = new System.Drawing.Size(120, 95);
            this.NumberPeople.TabIndex = 1;
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(475, 365);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(75, 23);
            this.Calculate.TabIndex = 3;
            this.Calculate.Text = "Calculate";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // Quit
            // 
            this.Quit.Location = new System.Drawing.Point(575, 365);
            this.Quit.Name = "Quit";
            this.Quit.Size = new System.Drawing.Size(75, 23);
            this.Quit.TabIndex = 4;
            this.Quit.Text = "Quit";
            this.Quit.UseVisualStyleBackColor = true;
            this.Quit.Click += new System.EventHandler(this.Close);
            // 
            // LabelBill
            // 
            this.LabelBill.AutoSize = true;
            this.LabelBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelBill.Location = new System.Drawing.Point(22, 65);
            this.LabelBill.Name = "LabelBill";
            this.LabelBill.Size = new System.Drawing.Size(37, 25);
            this.LabelBill.TabIndex = 5;
            this.LabelBill.Text = "Bill";
            // 
            // LabelPeople
            // 
            this.LabelPeople.AutoSize = true;
            this.LabelPeople.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPeople.Location = new System.Drawing.Point(22, 294);
            this.LabelPeople.Name = "LabelPeople";
            this.LabelPeople.Size = new System.Drawing.Size(166, 25);
            this.LabelPeople.TabIndex = 6;
            this.LabelPeople.Text = "Number of people";
            // 
            // GroupTip
            // 
            this.GroupTip.Controls.Add(this.RadioMad);
            this.GroupTip.Controls.Add(this.RadioGenerous);
            this.GroupTip.Controls.Add(this.RadioNormal);
            this.GroupTip.Controls.Add(this.RadioNone);
            this.GroupTip.Location = new System.Drawing.Point(43, 125);
            this.GroupTip.Name = "GroupTip";
            this.GroupTip.Size = new System.Drawing.Size(278, 109);
            this.GroupTip.TabIndex = 7;
            this.GroupTip.TabStop = false;
            this.GroupTip.Text = "Tip";
            // 
            // RadioMad
            // 
            this.RadioMad.AutoSize = true;
            this.RadioMad.Location = new System.Drawing.Point(174, 71);
            this.RadioMad.Name = "RadioMad";
            this.RadioMad.Size = new System.Drawing.Size(46, 17);
            this.RadioMad.TabIndex = 3;
            this.RadioMad.TabStop = true;
            this.RadioMad.Text = "Mad";
            this.RadioMad.UseVisualStyleBackColor = true;
            this.RadioMad.CheckedChanged += new System.EventHandler(this.MadTip);
            // 
            // RadioGenerous
            // 
            this.RadioGenerous.AutoSize = true;
            this.RadioGenerous.Location = new System.Drawing.Point(61, 71);
            this.RadioGenerous.Name = "RadioGenerous";
            this.RadioGenerous.Size = new System.Drawing.Size(71, 17);
            this.RadioGenerous.TabIndex = 2;
            this.RadioGenerous.TabStop = true;
            this.RadioGenerous.Text = "Generous";
            this.RadioGenerous.UseVisualStyleBackColor = true;
            this.RadioGenerous.CheckedChanged += new System.EventHandler(this.GenerousTip);
            // 
            // RadioNormal
            // 
            this.RadioNormal.AutoSize = true;
            this.RadioNormal.Location = new System.Drawing.Point(174, 19);
            this.RadioNormal.Name = "RadioNormal";
            this.RadioNormal.Size = new System.Drawing.Size(58, 17);
            this.RadioNormal.TabIndex = 1;
            this.RadioNormal.TabStop = true;
            this.RadioNormal.Text = "Normal";
            this.RadioNormal.UseVisualStyleBackColor = true;
            this.RadioNormal.CheckedChanged += new System.EventHandler(this.NormalTip);
            // 
            // RadioNone
            // 
            this.RadioNone.AutoSize = true;
            this.RadioNone.Location = new System.Drawing.Point(61, 19);
            this.RadioNone.Name = "RadioNone";
            this.RadioNone.Size = new System.Drawing.Size(51, 17);
            this.RadioNone.TabIndex = 0;
            this.RadioNone.TabStop = true;
            this.RadioNone.Text = "None";
            this.RadioNone.UseVisualStyleBackColor = true;
            // 
            // PictureBox
            // 
            this.PictureBox.BackgroundImage = global::DanielGraceWinApp.Properties.Resources._375_3751752_dining_table_clipart_elegant_dining_dinner_table_clipart;
            this.PictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PictureBox.Location = new System.Drawing.Point(412, 65);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(296, 270);
            this.PictureBox.TabIndex = 2;
            this.PictureBox.TabStop = false;
            // 
            // Tipster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 412);
            this.Controls.Add(this.GroupTip);
            this.Controls.Add(this.LabelPeople);
            this.Controls.Add(this.LabelBill);
            this.Controls.Add(this.Quit);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.PictureBox);
            this.Controls.Add(this.NumberPeople);
            this.Controls.Add(this.Bill);
            this.Name = "Tipster";
            this.Text = "Tipster";
            this.GroupTip.ResumeLayout(false);
            this.GroupTip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.Button Quit;
        private System.Windows.Forms.Label LabelBill;
        private System.Windows.Forms.Label LabelPeople;
        public System.Windows.Forms.TextBox Bill;
        public System.Windows.Forms.ListBox NumberPeople;
        private System.Windows.Forms.GroupBox GroupTip;
        private System.Windows.Forms.RadioButton RadioNormal;
        private System.Windows.Forms.RadioButton RadioNone;
        private System.Windows.Forms.RadioButton RadioMad;
        private System.Windows.Forms.RadioButton RadioGenerous;
    }
}