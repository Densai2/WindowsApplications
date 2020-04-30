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
            this.LabelNumberOne = new System.Windows.Forms.Label();
            this.LabelNumberTwo = new System.Windows.Forms.Label();
            this.ResultNumber = new System.Windows.Forms.Label();
            this.LineOne = new System.Windows.Forms.Panel();
            this.LineTwo = new System.Windows.Forms.Panel();
            this.LabelTitle = new System.Windows.Forms.Label();
            this.PowerOf = new System.Windows.Forms.Button();
            this.Average = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FirstNumber
            // 
            this.FirstNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNumber.Location = new System.Drawing.Point(225, 63);
            this.FirstNumber.Name = "FirstNumber";
            this.FirstNumber.Size = new System.Drawing.Size(100, 44);
            this.FirstNumber.TabIndex = 0;
            // 
            // SecondNumber
            // 
            this.SecondNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecondNumber.Location = new System.Drawing.Point(251, 123);
            this.SecondNumber.Name = "SecondNumber";
            this.SecondNumber.Size = new System.Drawing.Size(100, 44);
            this.SecondNumber.TabIndex = 1;
            // 
            // Add
            // 
            this.Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.Location = new System.Drawing.Point(163, 269);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(84, 33);
            this.Add.TabIndex = 2;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Addition);
            // 
            // Subtract
            // 
            this.Subtract.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Subtract.Location = new System.Drawing.Point(253, 269);
            this.Subtract.Name = "Subtract";
            this.Subtract.Size = new System.Drawing.Size(90, 33);
            this.Subtract.TabIndex = 3;
            this.Subtract.Text = "Subtract";
            this.Subtract.UseVisualStyleBackColor = true;
            this.Subtract.Click += new System.EventHandler(this.Subtraction);
            // 
            // Muliply
            // 
            this.Muliply.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Muliply.Location = new System.Drawing.Point(349, 269);
            this.Muliply.Name = "Muliply";
            this.Muliply.Size = new System.Drawing.Size(84, 33);
            this.Muliply.TabIndex = 4;
            this.Muliply.Text = "Multiply";
            this.Muliply.UseVisualStyleBackColor = true;
            this.Muliply.Click += new System.EventHandler(this.Multiplication);
            // 
            // Devision
            // 
            this.Devision.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Devision.Location = new System.Drawing.Point(439, 269);
            this.Devision.Name = "Devision";
            this.Devision.Size = new System.Drawing.Size(84, 33);
            this.Devision.TabIndex = 5;
            this.Devision.Text = "Divide";
            this.Devision.UseVisualStyleBackColor = true;
            this.Devision.Click += new System.EventHandler(this.Divide);
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Result.Location = new System.Drawing.Point(84, 208);
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
            this.Exit.Click += new System.EventHandler(this.ExitButton);
            // 
            // LabelNumberOne
            // 
            this.LabelNumberOne.AutoSize = true;
            this.LabelNumberOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNumberOne.Location = new System.Drawing.Point(84, 72);
            this.LabelNumberOne.Name = "LabelNumberOne";
            this.LabelNumberOne.Size = new System.Drawing.Size(135, 20);
            this.LabelNumberOne.TabIndex = 8;
            this.LabelNumberOne.Text = "Your first number:";
            // 
            // LabelNumberTwo
            // 
            this.LabelNumberTwo.AutoSize = true;
            this.LabelNumberTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNumberTwo.Location = new System.Drawing.Point(84, 139);
            this.LabelNumberTwo.Name = "LabelNumberTwo";
            this.LabelNumberTwo.Size = new System.Drawing.Size(161, 20);
            this.LabelNumberTwo.TabIndex = 9;
            this.LabelNumberTwo.Text = "Your second number:";
            // 
            // ResultNumber
            // 
            this.ResultNumber.AutoSize = true;
            this.ResultNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultNumber.Location = new System.Drawing.Point(145, 195);
            this.ResultNumber.Name = "ResultNumber";
            this.ResultNumber.Size = new System.Drawing.Size(0, 37);
            this.ResultNumber.TabIndex = 10;
            // 
            // LineOne
            // 
            this.LineOne.BackColor = System.Drawing.Color.Black;
            this.LineOne.Location = new System.Drawing.Point(73, 45);
            this.LineOne.Name = "LineOne";
            this.LineOne.Size = new System.Drawing.Size(510, 12);
            this.LineOne.TabIndex = 11;
            // 
            // LineTwo
            // 
            this.LineTwo.BackColor = System.Drawing.Color.Black;
            this.LineTwo.Location = new System.Drawing.Point(88, 324);
            this.LineTwo.Name = "LineTwo";
            this.LineTwo.Size = new System.Drawing.Size(510, 12);
            this.LineTwo.TabIndex = 12;
            // 
            // LabelTitle
            // 
            this.LabelTitle.AutoSize = true;
            this.LabelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTitle.Location = new System.Drawing.Point(182, 5);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(268, 37);
            this.LabelTitle.TabIndex = 13;
            this.LabelTitle.Text = "Simple Calculator";
            // 
            // PowerOf
            // 
            this.PowerOf.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PowerOf.Location = new System.Drawing.Point(73, 269);
            this.PowerOf.Name = "PowerOf";
            this.PowerOf.Size = new System.Drawing.Size(84, 33);
            this.PowerOf.TabIndex = 14;
            this.PowerOf.Text = "Power";
            this.PowerOf.UseVisualStyleBackColor = true;
            this.PowerOf.Click += new System.EventHandler(this.Power);
            // 
            // Average
            // 
            this.Average.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Average.Location = new System.Drawing.Point(529, 269);
            this.Average.Name = "Average";
            this.Average.Size = new System.Drawing.Size(90, 33);
            this.Average.TabIndex = 15;
            this.Average.Text = "Average";
            this.Average.UseVisualStyleBackColor = true;
            this.Average.Click += new System.EventHandler(this.Averages);
            // 
            // Clear
            // 
            this.Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear.Location = new System.Drawing.Point(278, 354);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(84, 33);
            this.Clear.TabIndex = 16;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.ClearNumbers);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(631, 401);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Average);
            this.Controls.Add(this.PowerOf);
            this.Controls.Add(this.LabelTitle);
            this.Controls.Add(this.LineTwo);
            this.Controls.Add(this.LineOne);
            this.Controls.Add(this.ResultNumber);
            this.Controls.Add(this.LabelNumberTwo);
            this.Controls.Add(this.LabelNumberOne);
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
        private System.Windows.Forms.Label LabelNumberOne;
        private System.Windows.Forms.Label LabelNumberTwo;
        private System.Windows.Forms.Label ResultNumber;
        private System.Windows.Forms.Panel LineOne;
        private System.Windows.Forms.Panel LineTwo;
        private System.Windows.Forms.Label LabelTitle;
        private System.Windows.Forms.Button PowerOf;
        private System.Windows.Forms.Button Average;
        private System.Windows.Forms.Button Clear;
    }
}