namespace DanielGraceWinApp
{
    partial class PoshNosh
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
            this.lblStarter = new System.Windows.Forms.Label();
            this.lblMain = new System.Windows.Forms.Label();
            this.lblDessert = new System.Windows.Forms.Label();
            this.lstMain = new System.Windows.Forms.ListBox();
            this.FinalCost = new System.Windows.Forms.Label();
            this.lstStarter = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Exit = new System.Windows.Forms.Button();
            this.lstDessert = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStarter
            // 
            this.lblStarter.AutoSize = true;
            this.lblStarter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStarter.Location = new System.Drawing.Point(90, 34);
            this.lblStarter.Name = "lblStarter";
            this.lblStarter.Size = new System.Drawing.Size(70, 25);
            this.lblStarter.TabIndex = 0;
            this.lblStarter.Text = "Starter";
            this.lblStarter.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblMain
            // 
            this.lblMain.AutoSize = true;
            this.lblMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMain.Location = new System.Drawing.Point(90, 173);
            this.lblMain.Name = "lblMain";
            this.lblMain.Size = new System.Drawing.Size(124, 25);
            this.lblMain.TabIndex = 1;
            this.lblMain.Text = "Main Course";
            // 
            // lblDessert
            // 
            this.lblDessert.AutoSize = true;
            this.lblDessert.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDessert.Location = new System.Drawing.Point(90, 308);
            this.lblDessert.Name = "lblDessert";
            this.lblDessert.Size = new System.Drawing.Size(79, 25);
            this.lblDessert.TabIndex = 2;
            this.lblDessert.Text = "Dessert";
            // 
            // lstMain
            // 
            this.lstMain.FormattingEnabled = true;
            this.lstMain.Items.AddRange(new object[] {
            "Chicken Lasagne",
            "Fish and Chips",
            "Steak and Chips",
            "Vegetable Curry"});
            this.lstMain.Location = new System.Drawing.Point(94, 201);
            this.lstMain.Name = "lstMain";
            this.lstMain.Size = new System.Drawing.Size(120, 95);
            this.lstMain.Sorted = true;
            this.lstMain.TabIndex = 4;
            this.lstMain.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // FinalCost
            // 
            this.FinalCost.AutoSize = true;
            this.FinalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinalCost.Location = new System.Drawing.Point(518, 364);
            this.FinalCost.Name = "FinalCost";
            this.FinalCost.Size = new System.Drawing.Size(0, 25);
            this.FinalCost.TabIndex = 5;
            this.FinalCost.Click += new System.EventHandler(this.FinalCost_Click);
            // 
            // lstStarter
            // 
            this.lstStarter.FormattingEnabled = true;
            this.lstStarter.Items.AddRange(new object[] {
            "Dough Balls",
            "Garlic Bread",
            "Prawns",
            "Soup of the day"});
            this.lstStarter.Location = new System.Drawing.Point(94, 66);
            this.lstStarter.Name = "lstStarter";
            this.lstStarter.Size = new System.Drawing.Size(120, 69);
            this.lstStarter.Sorted = true;
            this.lstStarter.TabIndex = 6;
            this.lstStarter.SelectedIndexChanged += new System.EventHandler(this.lstStarter_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::DanielGraceWinApp.Properties.Resources.unnamed1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(377, 66);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(346, 285);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(713, 415);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 8;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // lstDessert
            // 
            this.lstDessert.FormattingEnabled = true;
            this.lstDessert.Items.AddRange(new object[] {
            "Chocolate Fudge",
            "Custard",
            "Selection of Cheese",
            "Blueberry Muffin"});
            this.lstDessert.Location = new System.Drawing.Point(95, 336);
            this.lstDessert.Name = "lstDessert";
            this.lstDessert.Size = new System.Drawing.Size(121, 21);
            this.lstDessert.TabIndex = 9;
            this.lstDessert.Text = "Dessert Choices";
            this.lstDessert.SelectedIndexChanged += new System.EventHandler(this.lstDessert_SelectedIndexChanged);
            // 
            // PoshNosh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstDessert);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.lstStarter);
            this.Controls.Add(this.FinalCost);
            this.Controls.Add(this.lstMain);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblDessert);
            this.Controls.Add(this.lblMain);
            this.Controls.Add(this.lblStarter);
            this.Name = "PoshNosh";
            this.Text = "Posh Nosh Menu Selection";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStarter;
        private System.Windows.Forms.Label lblMain;
        private System.Windows.Forms.Label lblDessert;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox lstMain;
        private System.Windows.Forms.Label FinalCost;
        private System.Windows.Forms.ListBox lstStarter;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.ComboBox lstDessert;
    }
}