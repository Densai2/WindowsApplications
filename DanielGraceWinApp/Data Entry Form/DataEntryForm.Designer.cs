namespace DataEntryForm
{
    partial class DataEntryForm
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
            this.MainLabel = new System.Windows.Forms.Label();
            this.Quit = new System.Windows.Forms.Button();
            this.FirstName = new System.Windows.Forms.Label();
            this.SecondName = new System.Windows.Forms.Label();
            this.Message = new System.Windows.Forms.Label();
            this.FirstNameBox = new System.Windows.Forms.TextBox();
            this.SecondNameBox = new System.Windows.Forms.TextBox();
            this.DisplayMessage = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.UpperCase = new System.Windows.Forms.Button();
            this.MessageChange = new System.Windows.Forms.Button();
            this.Town = new System.Windows.Forms.Label();
            this.TownBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // MainLabel
            // 
            this.MainLabel.AutoSize = true;
            this.MainLabel.BackColor = System.Drawing.Color.Yellow;
            this.MainLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MainLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainLabel.Location = new System.Drawing.Point(50, 20);
            this.MainLabel.Name = "MainLabel";
            this.MainLabel.Size = new System.Drawing.Size(352, 39);
            this.MainLabel.TabIndex = 0;
            this.MainLabel.Text = "User Details Data Entry";
            // 
            // Quit
            // 
            this.Quit.Location = new System.Drawing.Point(477, 292);
            this.Quit.Name = "Quit";
            this.Quit.Size = new System.Drawing.Size(75, 23);
            this.Quit.TabIndex = 1;
            this.Quit.Text = "&Quit";
            this.Quit.UseVisualStyleBackColor = true;
            this.Quit.Click += new System.EventHandler(this.Exit);
            // 
            // FirstName
            // 
            this.FirstName.AutoSize = true;
            this.FirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstName.Location = new System.Drawing.Point(50, 80);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(106, 24);
            this.FirstName.TabIndex = 2;
            this.FirstName.Text = "First Name:";
            // 
            // SecondName
            // 
            this.SecondName.AutoSize = true;
            this.SecondName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecondName.Location = new System.Drawing.Point(50, 120);
            this.SecondName.Name = "SecondName";
            this.SecondName.Size = new System.Drawing.Size(92, 24);
            this.SecondName.TabIndex = 3;
            this.SecondName.Text = "Surname:";
            // 
            // Message
            // 
            this.Message.AutoSize = true;
            this.Message.BackColor = System.Drawing.Color.Yellow;
            this.Message.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Message.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Message.Location = new System.Drawing.Point(140, 197);
            this.Message.Name = "Message";
            this.Message.Size = new System.Drawing.Size(2, 26);
            this.Message.TabIndex = 4;
            // 
            // FirstNameBox
            // 
            this.FirstNameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FirstNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameBox.Location = new System.Drawing.Point(177, 80);
            this.FirstNameBox.Name = "FirstNameBox";
            this.FirstNameBox.Size = new System.Drawing.Size(175, 29);
            this.FirstNameBox.TabIndex = 5;
            // 
            // SecondNameBox
            // 
            this.SecondNameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SecondNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecondNameBox.Location = new System.Drawing.Point(177, 118);
            this.SecondNameBox.Name = "SecondNameBox";
            this.SecondNameBox.Size = new System.Drawing.Size(175, 29);
            this.SecondNameBox.TabIndex = 6;
            // 
            // DisplayMessage
            // 
            this.DisplayMessage.Location = new System.Drawing.Point(193, 292);
            this.DisplayMessage.Name = "DisplayMessage";
            this.DisplayMessage.Size = new System.Drawing.Size(75, 23);
            this.DisplayMessage.TabIndex = 7;
            this.DisplayMessage.Text = "&Message";
            this.DisplayMessage.UseVisualStyleBackColor = true;
            this.DisplayMessage.Click += new System.EventHandler(this.MessageToUser);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(327, 292);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(75, 23);
            this.Clear.TabIndex = 8;
            this.Clear.Text = "&Clear Message";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.ClearMessage);
            // 
            // UpperCase
            // 
            this.UpperCase.Location = new System.Drawing.Point(67, 292);
            this.UpperCase.Name = "UpperCase";
            this.UpperCase.Size = new System.Drawing.Size(75, 23);
            this.UpperCase.TabIndex = 9;
            this.UpperCase.Text = "&Upper case";
            this.UpperCase.UseVisualStyleBackColor = true;
            this.UpperCase.Click += new System.EventHandler(this.Capitals);
            // 
            // MessageChange
            // 
            this.MessageChange.Location = new System.Drawing.Point(228, 324);
            this.MessageChange.Name = "MessageChange";
            this.MessageChange.Size = new System.Drawing.Size(102, 25);
            this.MessageChange.TabIndex = 10;
            this.MessageChange.Text = "Change Message";
            this.MessageChange.UseVisualStyleBackColor = true;
            this.MessageChange.Click += new System.EventHandler(this.ChangeColour);
            // 
            // Town
            // 
            this.Town.AutoSize = true;
            this.Town.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Town.Location = new System.Drawing.Point(50, 158);
            this.Town.Name = "Town";
            this.Town.Size = new System.Drawing.Size(63, 24);
            this.Town.TabIndex = 11;
            this.Town.Text = "Town:";
            // 
            // TownBox
            // 
            this.TownBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TownBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TownBox.Location = new System.Drawing.Point(177, 158);
            this.TownBox.Name = "TownBox";
            this.TownBox.Size = new System.Drawing.Size(175, 29);
            this.TownBox.TabIndex = 12;
            // 
            // DataEntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(564, 361);
            this.Controls.Add(this.TownBox);
            this.Controls.Add(this.Town);
            this.Controls.Add(this.MessageChange);
            this.Controls.Add(this.UpperCase);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.DisplayMessage);
            this.Controls.Add(this.SecondNameBox);
            this.Controls.Add(this.FirstNameBox);
            this.Controls.Add(this.Message);
            this.Controls.Add(this.SecondName);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.Quit);
            this.Controls.Add(this.MainLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "DataEntryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DataEntryForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MainLabel;
        private System.Windows.Forms.Button Quit;
        private System.Windows.Forms.Label FirstName;
        private System.Windows.Forms.Label SecondName;
        private System.Windows.Forms.Label Message;
        private System.Windows.Forms.TextBox FirstNameBox;
        private System.Windows.Forms.TextBox SecondNameBox;
        private System.Windows.Forms.Button DisplayMessage;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button UpperCase;
        private System.Windows.Forms.Button MessageChange;
        private System.Windows.Forms.Label Town;
        private System.Windows.Forms.TextBox TownBox;
    }
}