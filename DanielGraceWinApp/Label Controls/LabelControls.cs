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
    public partial class LabelControls : Form
    {
        public LabelControls()
        {
            InitializeComponent();
        }

        private void Quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ButtonShow1_Click(object sender, EventArgs e)
        {
  
        }

        private void BestComputerText(object sender, EventArgs e)
        {
            ComputerText.Text = "Stunning computer, high fps! \n Selling for £596!";
        }

        private void BestSoftware(object sender, EventArgs e)
        {
            SoftwareText.Text = "Stunning software, great compatability! \n Selling for £246!";
        }

        private void BragText(object sender, EventArgs e)
        {

        }

        private void Greeting_Click(object sender, EventArgs e)
        {

        }

        private void LabelControls_Load(object sender, EventArgs e)
        {

        }
    }
}
