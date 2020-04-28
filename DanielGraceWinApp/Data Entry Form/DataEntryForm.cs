using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DataEntryForm
{
    /// <summary>
    /// The form will take the user's first name, second
    /// and town to then add to a sentence with their 
    /// details.
    /// </summary>
    public partial class DataEntryForm : Form
    {
        public DataEntryForm()
        {
            InitializeComponent();
        }

        private void Exit(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ClearMessage(object sender, EventArgs e)
        {
            Message.Text = "";
        }

        private void MessageToUser(object sender, EventArgs e)
        {
            Message.Text = "Hey, " + FirstNameBox.Text + " " + SecondNameBox.Text + "\n Happy programming" +  "\n Also, I didn't know you lived in " + TownBox.Text  + "!";
        }

        private void Capitals(object sender, EventArgs e)
        {
            Message.Text = Message.Text.ToUpper();
        }

        private void ChangeColour(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
            
        }
    }
}
