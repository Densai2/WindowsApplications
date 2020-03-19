namespace Calculation
{
    partial class Calculator
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
            this.FirstNumber = new System.Windows.Forms.TextBox();
            this.SecondNumber = new System.Windows.Forms.TextBox();
            this.Add = new System.Windows.Forms.Button();
            this.Subtract = new System.Windows.Forms.Button();
            this.Muliply = new System.Windows.Forms.Button();
            this.Devision = new System.Windows.Forms.Button();
            this.Result = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Button();
            this.Number1 = new System.Windows.Forms.Label();
            this.Number2 = new System.Windows.Forms.Label();
            this.ResultNumber = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FirstNumber
            // 
            this.FirstNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNumber.Location = new System.Drawing.Point(225, 63);
            this.FirstNumber.Name = "FirstNumber";
            this.FirstNumber.Size = new System.Drawing.Size(100, 44);
            this.FirstNumber.TabIndex = 0;
            this.FirstNumber.TextChanged += new System.EventHandler(this.FirstNumber_TextChanged);
            // 
            // SecondNumber
            // 
            this.SecondNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecondNumber.Location = new System.Drawing.Point(251, 123);
            this.SecondNumber.Name = "SecondNumber";
            this.SecondNumber.Size = new System.Drawing.Size(100, 44);
            this.SecondNumber.TabIndex = 1;
            this.SecondNumber.TextChanged += new System.EventHandler(this.SecondNumber_TextChanged);
            // 
            // Add
            // 
            this.Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.Location = new System.Drawing.Point(135, 269);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(84, 33);
            this.Add.TabIndex = 2;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Subtract
            // 
            this.Subtract.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Subtract.Location = new System.Drawing.Point(235, 269);
            this.Subtract.Name = "Subtract";
            this.Subtract.Size = new System.Drawing.Size(90, 33);
            this.Subtract.TabIndex = 3;
            this.Subtract.Text = "Subtract";
            this.Subtract.UseVisualStyleBackColor = true;
            this.Subtract.Click += new System.EventHandler(this.Subtract_Click);
            // 
            // Muliply
            // 
            this.Muliply.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Muliply.Location = new System.Drawing.Point(352, 269);
            this.Muliply.Name = "Muliply";
            this.Muliply.Size = new System.Drawing.Size(84, 33);
            this.Muliply.TabIndex = 4;
            this.Muliply.Text = "Multiply";
            this.Muliply.UseVisualStyleBackColor = true;
            this.Muliply.Click += new System.EventHandler(this.Muliply_Click);
            // 
            // Devision
            // 
            this.Devision.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Devision.Location = new System.Drawing.Point(458, 269);
            this.Devision.Name = "Devision";
            this.Devision.Size = new System.Drawing.Size(84, 33);
            this.Devision.TabIndex = 5;
            this.Devision.Text = "Divide";
            this.Devision.UseVisualStyleBackColor = true;
            this.Devision.Click += new System.EventHandler(this.Devision_Click);
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Result.Location = new System.Drawing.Point(85, 188);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(55, 20);
            this.Result.TabIndex = 6;
            this.Result.Text = "Result";
            // 
            // Exit
            // 
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Location = new System.Drawing.Point(539, 352);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(80, 37);
            this.Exit.TabIndex = 7;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Number1
            // 
            this.Number1.AutoSize = true;
            this.Number1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Number1.Location = new System.Drawing.Point(84, 72);
            this.Number1.Name = "Number1";
            this.Number1.Size = new System.Drawing.Size(135, 20);
            this.Number1.TabIndex = 8;
            this.Number1.Text = "Your first number:";
            // 
            // Number2
            // 
            this.Number2.AutoSize = true;
            this.Number2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Number2.Location = new System.Drawing.Point(84, 139);
            this.Number2.Name = "Number2";
            this.Number2.Size = new System.Drawing.Size(161, 20);
            this.Number2.TabIndex = 9;
            this.Number2.Text = "Your second number:";
            // 
            // ResultNumber
            // 
            this.ResultNumber.AutoSize = true;
            this.ResultNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultNumber.Location = new System.Drawing.Point(146, 175);
            this.ResultNumber.Name = "ResultNumber";
            this.ResultNumber.Size = new System.Drawing.Size(0, 37);
            this.ResultNumber.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(73, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(510, 12);
            this.panel1.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(88, 324);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(510, 12);
            this.panel2.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(182, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 37);
            this.label1.TabIndex = 13;
            this.label1.Text = "Simple Calculator";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(631, 401);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ResultNumber);
            this.Controls.Add(this.Number2);
            this.Controls.Add(this.Number1);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.Devision);
            this.Controls.Add(this.Muliply);
            this.Controls.Add(this.Subtract);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.SecondNumber);
            this.Controls.Add(this.FirstNumber);
            this.Name = "Calculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Calculator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FirstNumber;
        private System.Windows.Forms.TextBox SecondNumber;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Subtract;
        private System.Windows.Forms.Button Muliply;
        private System.Windows.Forms.Button Devision;
        private System.Windows.Forms.Label Result;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label Number1;
        private System.Windows.Forms.Label Number2;
        private System.Windows.Forms.Label ResultNumber;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
    }
}