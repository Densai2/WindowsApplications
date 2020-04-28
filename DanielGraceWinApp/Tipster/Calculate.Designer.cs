namespace DanielGraceWinApp.Tipster
{
    partial class Calculate
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
            this.BillDetails = new System.Windows.Forms.GroupBox();
            this.People = new System.Windows.Forms.TextBox();
            this.TotalBill = new System.Windows.Forms.TextBox();
            this.LabelPeople = new System.Windows.Forms.Label();
            this.TextTotalBill = new System.Windows.Forms.Label();
            this.BoxEachPays = new System.Windows.Forms.GroupBox();
            this.EachPays = new System.Windows.Forms.TextBox();
            this.LabelEachPays = new System.Windows.Forms.Label();
            this.Close = new System.Windows.Forms.Button();
            this.BillDetails.SuspendLayout();
            this.BoxEachPays.SuspendLayout();
            this.SuspendLayout();
            // 
            // BillDetails
            // 
            this.BillDetails.Controls.Add(this.People);
            this.BillDetails.Controls.Add(this.TotalBill);
            this.BillDetails.Controls.Add(this.LabelPeople);
            this.BillDetails.Controls.Add(this.TextTotalBill);
            this.BillDetails.Location = new System.Drawing.Point(53, 35);
            this.BillDetails.Name = "BillDetails";
            this.BillDetails.Size = new System.Drawing.Size(464, 150);
            this.BillDetails.TabIndex = 0;
            this.BillDetails.TabStop = false;
            this.BillDetails.Text = "Bill Details";
            // 
            // People
            // 
            this.People.BackColor = System.Drawing.Color.LightGray;
            this.People.Location = new System.Drawing.Point(68, 63);
            this.People.Name = "People";
            this.People.Size = new System.Drawing.Size(100, 20);
            this.People.TabIndex = 3;
            // 
            // TotalBill
            // 
            this.TotalBill.BackColor = System.Drawing.Color.LightGray;
            this.TotalBill.Location = new System.Drawing.Point(75, 32);
            this.TotalBill.Name = "TotalBill";
            this.TotalBill.Size = new System.Drawing.Size(100, 20);
            this.TotalBill.TabIndex = 2;
            // 
            // LabelPeople
            // 
            this.LabelPeople.AutoSize = true;
            this.LabelPeople.Location = new System.Drawing.Point(22, 66);
            this.LabelPeople.Name = "LabelPeople";
            this.LabelPeople.Size = new System.Drawing.Size(40, 13);
            this.LabelPeople.TabIndex = 1;
            this.LabelPeople.Text = "People";
            // 
            // TextTotalBill
            // 
            this.TextTotalBill.AutoSize = true;
            this.TextTotalBill.Location = new System.Drawing.Point(22, 35);
            this.TextTotalBill.Name = "TextTotalBill";
            this.TextTotalBill.Size = new System.Drawing.Size(47, 13);
            this.TextTotalBill.TabIndex = 0;
            this.TextTotalBill.Text = "Total Bill";
            // 
            // BoxEachPays
            // 
            this.BoxEachPays.Controls.Add(this.EachPays);
            this.BoxEachPays.Controls.Add(this.LabelEachPays);
            this.BoxEachPays.Location = new System.Drawing.Point(53, 202);
            this.BoxEachPays.Name = "BoxEachPays";
            this.BoxEachPays.Size = new System.Drawing.Size(464, 150);
            this.BoxEachPays.TabIndex = 0;
            this.BoxEachPays.TabStop = false;
            // 
            // EachPays
            // 
            this.EachPays.BackColor = System.Drawing.Color.LightGray;
            this.EachPays.Location = new System.Drawing.Point(105, 67);
            this.EachPays.Name = "EachPays";
            this.EachPays.Size = new System.Drawing.Size(100, 20);
            this.EachPays.TabIndex = 1;
            // 
            // LabelEachPays
            // 
            this.LabelEachPays.AutoSize = true;
            this.LabelEachPays.Location = new System.Drawing.Point(41, 70);
            this.LabelEachPays.Name = "LabelEachPays";
            this.LabelEachPays.Size = new System.Drawing.Size(58, 13);
            this.LabelEachPays.TabIndex = 0;
            this.LabelEachPays.Text = "Each Pays";
            // 
            // Close
            // 
            this.Close.Location = new System.Drawing.Point(605, 357);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(98, 43);
            this.Close.TabIndex = 2;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Quit);
            // 
            // Calculate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 412);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.BoxEachPays);
            this.Controls.Add(this.BillDetails);
            this.Name = "Calculate";
            this.Text = "Calculate";
            this.Load += new System.EventHandler(this.Calculation);
            this.BillDetails.ResumeLayout(false);
            this.BillDetails.PerformLayout();
            this.BoxEachPays.ResumeLayout(false);
            this.BoxEachPays.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox BillDetails;
        private System.Windows.Forms.GroupBox BoxEachPays;
        private System.Windows.Forms.Label LabelPeople;
        private System.Windows.Forms.Label TextTotalBill;
        private System.Windows.Forms.Label LabelEachPays;
        public System.Windows.Forms.TextBox People;
        public System.Windows.Forms.TextBox TotalBill;
        public System.Windows.Forms.TextBox EachPays;
        private System.Windows.Forms.Button Close;
    }
}