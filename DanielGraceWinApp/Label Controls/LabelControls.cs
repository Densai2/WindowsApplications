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
    /// This app allows the buttons to be interactive with
    /// the user, allowing them to change when clicked.
    /// </summary>
    public partial class LabelControls : Form
    {
        public LabelControls()
        {
            InitializeComponent();
        }

        private void Exit(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BestComputerText(object sender, EventArgs e)
        {
            ComputerText.Text = "Stunning computer, high fps! \n Selling for £596!";
        }

        private void BestSoftware(object sender, EventArgs e)
        {
            SoftwareText.Text = "Stunning software, great compatability! \n Selling for £246!";
        }
    }
}
