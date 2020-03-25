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
    public partial class CurrencyConverter : Form
    {
        public CurrencyConverter()
        {
            InitializeComponent();
        }

        private void CurrencyConverter_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
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

        private void radioDollars_CheckedChanged(object sender, EventArgs e)
        {
            double amount;
            amount = Convert.ToDouble(UKPounds.Text) * 1.8;
            EndAmount.Text = amount.ToString() + " Dollars";

        }

        private void ConvertedAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void UKPounds_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioEuros_CheckedChanged(object sender, EventArgs e)
        {
            double amount;
            amount = Convert.ToDouble(UKPounds.Text) * 1.4;
            EndAmount.Text = amount.ToString() + " Euros";
        }

        private void radioRupees_CheckedChanged(object sender, EventArgs e)
        {
            double amount;
            amount = Convert.ToDouble(UKPounds.Text) * 80;
            EndAmount.Text = amount.ToString() + " Ruppes";
        }
    }
}
