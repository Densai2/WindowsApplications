using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DanielGraceWinApp
{
    /// <summary>
    /// This form is to take the user's UK pounds
    /// and then convert them into their desired currency:
    /// Dolars, euros or ruppes
    /// </summary>
    public partial class CurrencyConverter : Form
    {
        public CurrencyConverter()
        {
            InitializeComponent();
        }

        private void Confirmation(object sender, EventArgs e)
        {
            DialogResult resultMessage = MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNo);
            if (resultMessage == DialogResult.Yes)
            {
                Application.ExitThread();
            }
            else
            {
                MessageBox.Show("Cancelled");

            }
        }

        private void Dolars(object sender, EventArgs e)
        {
            double amount;
            amount = Convert.ToDouble(UKPounds.Text) * 1.8;
            EndAmount.Text = amount.ToString() + " Dollars";

        }


        private void Euros(object sender, EventArgs e)
        {
            double amount;
            amount = Convert.ToDouble(UKPounds.Text) * 1.4;
            EndAmount.Text = amount.ToString() + " Euros";
        }

        private void Ruppes(object sender, EventArgs e)
        {
            double amount;
            amount = Convert.ToDouble(UKPounds.Text) * 80;
            EndAmount.Text = amount.ToString() + " Ruppes";
        }
    }
}
