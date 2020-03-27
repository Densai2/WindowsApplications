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
            this.BoxEachPays = new System.Windows.Forms.GroupBox();
            this.TextTotalBill = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TotalBill = new System.Windows.Forms.TextBox();
            this.People = new System.Windows.Forms.TextBox();
            this.LabelEachPays = new System.Windows.Forms.Label();
            this.EachPays = new System.Windows.Forms.TextBox();
            this.Close = new System.Windows.Forms.Button();
            this.BillDetails.SuspendLayout();
            this.BoxEachPays.SuspendLayout();
            this.SuspendLayout();
            // 
            // BillDetails
            // 
            this.BillDetails.Controls.Add(this.People);
            this.BillDetails.Controls.Add(this.TotalBill);
            this.BillDetails.Controls.Add(this.label1);
            this.BillDetails.Controls.Add(this.TextTotalBill);
            this.BillDetails.Location = new System.Drawing.Point(53, 35);
            this.BillDetails.Name = "BillDetails";
            this.BillDetails.Size = new System.Drawing.Size(464, 150);
            this.BillDetails.TabIndex = 0;
            this.BillDetails.TabStop = false;
            this.BillDetails.Text = "Bill Details";
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
            // TextTotalBill
            // 
            this.TextTotalBill.AutoSize = true;
            this.TextTotalBill.Location = new System.Drawing.Point(22, 35);
            this.TextTotalBill.Name = "TextTotalBill";
            this.TextTotalBill.Size = new System.Drawing.Size(47, 13);
            this.TextTotalBill.TabIndex = 0;
            this.TextTotalBill.Text = "Total Bill";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "People";
            // 
            // TotalBill
            // 
            this.TotalBill.BackColor = System.Drawing.Color.LightGray;
            this.TotalBill.Location = new System.Drawing.Point(75, 32);
            this.TotalBill.Name = "TotalBill";
            this.TotalBill.Size = new System.Drawing.Size(100, 20);
            this.TotalBill.TabIndex = 2;
            // 
            // People
            // 
            this.People.BackColor = System.Drawing.Color.LightGray;
            this.People.Location = new System.Drawing.Point(68, 63);
            this.People.Name = "People";
            this.People.Size = new System.Drawing.Size(100, 20);
            this.People.TabIndex = 3;
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
            // EachPays
            // 
            this.EachPays.BackColor = System.Drawing.Color.LightGray;
            this.EachPays.Location = new System.Drawing.Point(105, 67);
            this.EachPays.Name = "EachPays";
            this.EachPays.Size = new System.Drawing.Size(100, 20);
            this.EachPays.TabIndex = 1;
            // 
            // Close
            // 
            this.Close.Location = new System.Drawing.Point(605, 357);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(98, 43);
            this.Close.TabIndex = 2;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
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
            this.Load += new System.EventHandler(this.Calculate_Load);
            this.BillDetails.ResumeLayout(false);
            this.BillDetails.PerformLayout();
            this.BoxEachPays.ResumeLayout(false);
            this.BoxEachPays.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox BillDetails;
        private System.Windows.Forms.GroupBox BoxEachPays;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TextTotalBill;
        private System.Windows.Forms.Label LabelEachPays;
        public System.Windows.Forms.TextBox People;
        public System.Windows.Forms.TextBox TotalBill;
        public System.Windows.Forms.TextBox EachPays;
        private System.Windows.Forms.Button Close;
    }
}