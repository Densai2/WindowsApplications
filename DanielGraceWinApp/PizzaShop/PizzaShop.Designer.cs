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
            this.grpToppings = new System.Windows.Forms.GroupBox();
            this.Chocolate = new System.Windows.Forms.CheckBox();
            this.Pepperoni = new System.Windows.Forms.CheckBox();
            this.Rhubard = new System.Windows.Forms.CheckBox();
            this.Pineapple = new System.Windows.Forms.CheckBox();
            this.grpPizzaCost = new System.Windows.Forms.GroupBox();
            this.EndCost = new System.Windows.Forms.Label();
            this.grpPizzaType = new System.Windows.Forms.GroupBox();
            this.Small = new System.Windows.Forms.RadioButton();
            this.Medium = new System.Windows.Forms.RadioButton();
            this.Large = new System.Windows.Forms.RadioButton();
            this.grpToppings.SuspendLayout();
            this.grpPizzaCost.SuspendLayout();
            this.grpPizzaType.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpToppings
            // 
            this.grpToppings.Controls.Add(this.Chocolate);
            this.grpToppings.Controls.Add(this.Pepperoni);
            this.grpToppings.Controls.Add(this.Rhubard);
            this.grpToppings.Controls.Add(this.Pineapple);
            this.grpToppings.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpToppings.Location = new System.Drawing.Point(435, 55);
            this.grpToppings.Name = "grpToppings";
            this.grpToppings.Size = new System.Drawing.Size(327, 277);
            this.grpToppings.TabIndex = 0;
            this.grpToppings.TabStop = false;
            this.grpToppings.Text = "Toppings";
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
            this.Chocolate.CheckedChanged += new System.EventHandler(this.Chocolate_CheckedChanged);
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
            this.Pepperoni.CheckedChanged += new System.EventHandler(this.Pepperoni_CheckedChanged);
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
            this.Rhubard.CheckedChanged += new System.EventHandler(this.Rhubard_CheckedChanged);
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
            this.Pineapple.CheckedChanged += new System.EventHandler(this.Pineapple_CheckedChanged);
            // 
            // grpPizzaCost
            // 
            this.grpPizzaCost.Controls.Add(this.EndCost);
            this.grpPizzaCost.Location = new System.Drawing.Point(176, 338);
            this.grpPizzaCost.Name = "grpPizzaCost";
            this.grpPizzaCost.Size = new System.Drawing.Size(488, 100);
            this.grpPizzaCost.TabIndex = 1;
            this.grpPizzaCost.TabStop = false;
            this.grpPizzaCost.Text = "Pizza Cost";
            this.grpPizzaCost.Enter += new System.EventHandler(this.grpPizzaCost_Enter);
            // 
            // EndCost
            // 
            this.EndCost.AutoSize = true;
            this.EndCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndCost.Location = new System.Drawing.Point(23, 40);
            this.EndCost.Name = "EndCost";
            this.EndCost.Size = new System.Drawing.Size(0, 25);
            this.EndCost.TabIndex = 0;
            this.EndCost.Click += new System.EventHandler(this.label1_Click);
            // 
            // grpPizzaType
            // 
            this.grpPizzaType.Controls.Add(this.Small);
            this.grpPizzaType.Controls.Add(this.Medium);
            this.grpPizzaType.Controls.Add(this.Large);
            this.grpPizzaType.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPizzaType.Location = new System.Drawing.Point(85, 55);
            this.grpPizzaType.Name = "grpPizzaType";
            this.grpPizzaType.Size = new System.Drawing.Size(227, 277);
            this.grpPizzaType.TabIndex = 2;
            this.grpPizzaType.TabStop = false;
            this.grpPizzaType.Text = "Pizza Type";
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
            this.Small.CheckedChanged += new System.EventHandler(this.Small_CheckedChanged);
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
            this.Medium.CheckedChanged += new System.EventHandler(this.Medium_CheckedChanged);
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
            this.Large.CheckedChanged += new System.EventHandler(this.Large_CheckedChanged);
            // 
            // PizzaShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpPizzaType);
            this.Controls.Add(this.grpPizzaCost);
            this.Controls.Add(this.grpToppings);
            this.Name = "PizzaShop";
            this.Text = "Pizza Shop Selection Screen";
            this.Load += new System.EventHandler(this.PizzaShop_Load);
            this.grpToppings.ResumeLayout(false);
            this.grpToppings.PerformLayout();
            this.grpPizzaCost.ResumeLayout(false);
            this.grpPizzaCost.PerformLayout();
            this.grpPizzaType.ResumeLayout(false);
            this.grpPizzaType.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpToppings;
        private System.Windows.Forms.CheckBox Chocolate;
        private System.Windows.Forms.CheckBox Pepperoni;
        private System.Windows.Forms.CheckBox Rhubard;
        private System.Windows.Forms.CheckBox Pineapple;
        private System.Windows.Forms.GroupBox grpPizzaCost;
        private System.Windows.Forms.GroupBox grpPizzaType;
        private System.Windows.Forms.RadioButton Small;
        private System.Windows.Forms.RadioButton Medium;
        private System.Windows.Forms.RadioButton Large;
        private System.Windows.Forms.Label EndCost;
    }
}