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
            this.LabelStarter = new System.Windows.Forms.Label();
            this.LabelMain = new System.Windows.Forms.Label();
            this.LabelDessert = new System.Windows.Forms.Label();
            this.Mains = new System.Windows.Forms.ListBox();
            this.FinalCost = new System.Windows.Forms.Label();
            this.Starters = new System.Windows.Forms.ListBox();
            this.Picture = new System.Windows.Forms.PictureBox();
            this.Exit = new System.Windows.Forms.Button();
            this.Deserts = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelStarter
            // 
            this.LabelStarter.AutoSize = true;
            this.LabelStarter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelStarter.Location = new System.Drawing.Point(90, 34);
            this.LabelStarter.Name = "LabelStarter";
            this.LabelStarter.Size = new System.Drawing.Size(70, 25);
            this.LabelStarter.TabIndex = 0;
            this.LabelStarter.Text = "Starter";            // 
            // LabelMain
            // 
            this.LabelMain.AutoSize = true;
            this.LabelMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelMain.Location = new System.Drawing.Point(90, 173);
            this.LabelMain.Name = "LabelMain";
            this.LabelMain.Size = new System.Drawing.Size(124, 25);
            this.LabelMain.TabIndex = 1;
            this.LabelMain.Text = "Main Course";
            // 
            // LabelDessert
            // 
            this.LabelDessert.AutoSize = true;
            this.LabelDessert.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDessert.Location = new System.Drawing.Point(90, 308);
            this.LabelDessert.Name = "LabelDessert";
            this.LabelDessert.Size = new System.Drawing.Size(79, 25);
            this.LabelDessert.TabIndex = 2;
            this.LabelDessert.Text = "Dessert";
            // 
            // Mains
            // 
            this.Mains.FormattingEnabled = true;
            this.Mains.Items.AddRange(new object[] {
            "Chicken Lasagne",
            "Fish and Chips",
            "Steak and Chips",
            "Vegetable Curry"});
            this.Mains.Location = new System.Drawing.Point(94, 201);
            this.Mains.Name = "Mains";
            this.Mains.Size = new System.Drawing.Size(120, 95);
            this.Mains.Sorted = true;
            this.Mains.TabIndex = 4;
            this.Mains.SelectedIndexChanged += new System.EventHandler(this.MainChoice);
            // 
            // FinalCost
            // 
            this.FinalCost.AutoSize = true;
            this.FinalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinalCost.Location = new System.Drawing.Point(518, 364);
            this.FinalCost.Name = "FinalCost";
            this.FinalCost.Size = new System.Drawing.Size(0, 25);
            this.FinalCost.TabIndex = 5;
            // 
            // Starters
            // 
            this.Starters.FormattingEnabled = true;
            this.Starters.Items.AddRange(new object[] {
            "Dough Balls",
            "Garlic Bread",
            "Prawns",
            "Soup of the day"});
            this.Starters.Location = new System.Drawing.Point(94, 66);
            this.Starters.Name = "Starters";
            this.Starters.Size = new System.Drawing.Size(120, 69);
            this.Starters.Sorted = true;
            this.Starters.TabIndex = 6;
            this.Starters.SelectedIndexChanged += new System.EventHandler(this.StarterChoice);
            // 
            // Picture
            // 
            this.Picture.BackgroundImage = global::DanielGraceWinApp.Properties.Resources.unnamed1;
            this.Picture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Picture.Location = new System.Drawing.Point(377, 66);
            this.Picture.Name = "Picture";
            this.Picture.Size = new System.Drawing.Size(346, 285);
            this.Picture.TabIndex = 3;
            this.Picture.TabStop = false;
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(713, 415);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 8;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Close);
            // 
            // Deserts
            // 
            this.Deserts.FormattingEnabled = true;
            this.Deserts.Items.AddRange(new object[] {
            "Chocolate Fudge",
            "Custard",
            "Selection of Cheese",
            "Blueberry Muffin"});
            this.Deserts.Location = new System.Drawing.Point(95, 336);
            this.Deserts.Name = "Deserts";
            this.Deserts.Size = new System.Drawing.Size(121, 21);
            this.Deserts.TabIndex = 9;
            this.Deserts.Text = "Dessert Choices";
            this.Deserts.SelectedIndexChanged += new System.EventHandler(this.DessertChoice);
            // 
            // PoshNosh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Deserts);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Starters);
            this.Controls.Add(this.FinalCost);
            this.Controls.Add(this.Mains);
            this.Controls.Add(this.Picture);
            this.Controls.Add(this.LabelDessert);
            this.Controls.Add(this.LabelMain);
            this.Controls.Add(this.LabelStarter);
            this.Name = "PoshNosh";
            this.Text = "Posh Nosh Menu Selection";
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelStarter;
        private System.Windows.Forms.Label LabelMain;
        private System.Windows.Forms.Label LabelDessert;
        private System.Windows.Forms.PictureBox Picture;
        private System.Windows.Forms.ListBox Mains;
        private System.Windows.Forms.Label FinalCost;
        private System.Windows.Forms.ListBox Starters;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.ComboBox Deserts;
    }
}