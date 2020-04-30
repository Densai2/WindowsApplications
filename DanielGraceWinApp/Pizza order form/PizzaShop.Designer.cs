namespace DanielGraceWinApp.PizzaShop
{
    partial class PizzaShop
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
            this.Toppings = new System.Windows.Forms.GroupBox();
            this.Chocolate = new System.Windows.Forms.CheckBox();
            this.Pepperoni = new System.Windows.Forms.CheckBox();
            this.Rhubard = new System.Windows.Forms.CheckBox();
            this.Pineapple = new System.Windows.Forms.CheckBox();
            this.PizzaCost = new System.Windows.Forms.GroupBox();
            this.EndCost = new System.Windows.Forms.Label();
            this.PizzaType = new System.Windows.Forms.GroupBox();
            this.Small = new System.Windows.Forms.RadioButton();
            this.Medium = new System.Windows.Forms.RadioButton();
            this.Large = new System.Windows.Forms.RadioButton();
            this.Toppings.SuspendLayout();
            this.PizzaCost.SuspendLayout();
            this.PizzaType.SuspendLayout();
            this.SuspendLayout();
            // 
            // Toppings
            // 
            this.Toppings.Controls.Add(this.Chocolate);
            this.Toppings.Controls.Add(this.Pepperoni);
            this.Toppings.Controls.Add(this.Rhubard);
            this.Toppings.Controls.Add(this.Pineapple);
            this.Toppings.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Toppings.Location = new System.Drawing.Point(435, 55);
            this.Toppings.Name = "Toppings";
            this.Toppings.Size = new System.Drawing.Size(327, 277);
            this.Toppings.TabIndex = 0;
            this.Toppings.TabStop = false;
            this.Toppings.Text = "Toppings";
            // 
            // Chocolate
            // 
            this.Chocolate.AutoSize = true;
            this.Chocolate.Location = new System.Drawing.Point(54, 215);
            this.Chocolate.Name = "Chocolate";
            this.Chocolate.Size = new System.Drawing.Size(120, 29);
            this.Chocolate.TabIndex = 3;
            this.Chocolate.Text = "Chocolate";
            this.Chocolate.UseVisualStyleBackColor = true;
            this.Chocolate.CheckedChanged += new System.EventHandler(this.Chocolate_Checked);
            // 
            // Pepperoni
            // 
            this.Pepperoni.AutoSize = true;
            this.Pepperoni.Location = new System.Drawing.Point(54, 168);
            this.Pepperoni.Name = "Pepperoni";
            this.Pepperoni.Size = new System.Drawing.Size(202, 29);
            this.Pepperoni.TabIndex = 2;
            this.Pepperoni.Text = "Pepperoni Vindaloo";
            this.Pepperoni.UseVisualStyleBackColor = true;
            this.Pepperoni.CheckedChanged += new System.EventHandler(this.Pepperoni_Checked);
            // 
            // Rhubard
            // 
            this.Rhubard.AutoSize = true;
            this.Rhubard.Location = new System.Drawing.Point(54, 119);
            this.Rhubard.Name = "Rhubard";
            this.Rhubard.Size = new System.Drawing.Size(217, 29);
            this.Rhubard.TabIndex = 1;
            this.Rhubard.Text = "Rhubard and Custard";
            this.Rhubard.UseVisualStyleBackColor = true;
            this.Rhubard.CheckedChanged += new System.EventHandler(this.Rhubard_Checked);
            // 
            // Pineapple
            // 
            this.Pineapple.AutoSize = true;
            this.Pineapple.Location = new System.Drawing.Point(54, 68);
            this.Pineapple.Name = "Pineapple";
            this.Pineapple.Size = new System.Drawing.Size(257, 29);
            this.Pineapple.TabIndex = 0;
            this.Pineapple.Text = "Pineapple and Cauliflower";
            this.Pineapple.UseVisualStyleBackColor = true;
            this.Pineapple.CheckedChanged += new System.EventHandler(this.Pineapple_Checked);
            // 
            // PizzaCost
            // 
            this.PizzaCost.Controls.Add(this.EndCost);
            this.PizzaCost.Location = new System.Drawing.Point(176, 338);
            this.PizzaCost.Name = "PizzaCost";
            this.PizzaCost.Size = new System.Drawing.Size(488, 100);
            this.PizzaCost.TabIndex = 1;
            this.PizzaCost.TabStop = false;
            this.PizzaCost.Text = "Pizza Cost";            // 
            // EndCost
            // 
            this.EndCost.AutoSize = true;
            this.EndCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndCost.Location = new System.Drawing.Point(23, 40);
            this.EndCost.Name = "EndCost";
            this.EndCost.Size = new System.Drawing.Size(0, 25);
            this.EndCost.TabIndex = 0;            // 
            // PizzaType
            // 
            this.PizzaType.Controls.Add(this.Small);
            this.PizzaType.Controls.Add(this.Medium);
            this.PizzaType.Controls.Add(this.Large);
            this.PizzaType.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PizzaType.Location = new System.Drawing.Point(85, 55);
            this.PizzaType.Name = "PizzaType";
            this.PizzaType.Size = new System.Drawing.Size(227, 277);
            this.PizzaType.TabIndex = 2;
            this.PizzaType.TabStop = false;
            this.PizzaType.Text = "Pizza Type";
            // 
            // Small
            // 
            this.Small.AutoSize = true;
            this.Small.Location = new System.Drawing.Point(22, 168);
            this.Small.Name = "Small";
            this.Small.Size = new System.Drawing.Size(79, 29);
            this.Small.TabIndex = 2;
            this.Small.TabStop = true;
            this.Small.Text = "Small";
            this.Small.UseVisualStyleBackColor = true;
            this.Small.CheckedChanged += new System.EventHandler(this.Small_Checked);
            // 
            // Medium
            // 
            this.Medium.AutoSize = true;
            this.Medium.Location = new System.Drawing.Point(22, 119);
            this.Medium.Name = "Medium";
            this.Medium.Size = new System.Drawing.Size(100, 29);
            this.Medium.TabIndex = 1;
            this.Medium.TabStop = true;
            this.Medium.Text = "Medium";
            this.Medium.UseVisualStyleBackColor = true;
            this.Medium.CheckedChanged += new System.EventHandler(this.Medium_Checked);
            // 
            // Large
            // 
            this.Large.AutoSize = true;
            this.Large.Location = new System.Drawing.Point(22, 67);
            this.Large.Name = "Large";
            this.Large.Size = new System.Drawing.Size(80, 29);
            this.Large.TabIndex = 0;
            this.Large.TabStop = true;
            this.Large.Text = "Large";
            this.Large.UseVisualStyleBackColor = true;
            this.Large.CheckedChanged += new System.EventHandler(this.Large_Checked);
            // 
            // PizzaShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PizzaType);
            this.Controls.Add(this.PizzaCost);
            this.Controls.Add(this.Toppings);
            this.Name = "PizzaShop";
            this.Text = "Pizza Shop Selection Screen";
            this.Toppings.ResumeLayout(false);
            this.Toppings.PerformLayout();
            this.PizzaCost.ResumeLayout(false);
            this.PizzaCost.PerformLayout();
            this.PizzaType.ResumeLayout(false);
            this.PizzaType.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Toppings;
        private System.Windows.Forms.CheckBox Chocolate;
        private System.Windows.Forms.CheckBox Pepperoni;
        private System.Windows.Forms.CheckBox Rhubard;
        private System.Windows.Forms.CheckBox Pineapple;
        private System.Windows.Forms.GroupBox PizzaCost;
        private System.Windows.Forms.GroupBox PizzaType;
        private System.Windows.Forms.RadioButton Small;
        private System.Windows.Forms.RadioButton Medium;
        private System.Windows.Forms.RadioButton Large;
        private System.Windows.Forms.Label EndCost;
    }
}