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

        private void BestComputer_Click(object sender, EventArgs e)
        {
            Brag.Text = "Supa Dupa Computer\n Selling for £699";
            Brag.BackColor = Color.Orange;
            Brag.ForeColor = Color.White;
        }

        private void BestSoftware_Click(object sender, EventArgs e)
        {
            Brag.Text = "C#.NET for Dumbos\n A unbelievable bargain at £34,423.01";
            Brag.BackColor = Color.Black;
            Brag.ForeColor = Color.Yellow;
        }
    }
}
