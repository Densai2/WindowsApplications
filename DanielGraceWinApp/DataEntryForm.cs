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
    public partial class DataEntryForm : Form
    {
        public DataEntryForm()
        {
            InitializeComponent();
        }

        private void FirstNameBox_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void DataEntryForm_Load(object sender, EventArgs e)
        {

        }

        private void Quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ClearMessage(object sender, EventArgs e)
        {
            Message.Text = "";
        }

        private void Message1_Click(object sender, EventArgs e)
        {
            Message.Text = "Hey, " + FirstNameBox.Text + " " + SecondNameBox.Text + "\n Happy programming" +  "\n Also, I didn't know you lived in " + TownBox.Text  + "!";
        }

        private void Message_Click(object sender, EventArgs e)
        {

        }

        private void UpperCase_Click(object sender, EventArgs e)
        {
            Message.Text = Message.Text.ToUpper();
        }

        private void MessageChange_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
            
        }

        private void SecondNameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void TownBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
