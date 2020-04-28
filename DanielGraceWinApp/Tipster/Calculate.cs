using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DanielGraceWinApp.Tipster;

namespace DanielGraceWinApp.Tipster
{
    
    public partial class Calculate : Form
    {
        /// <summary>
        /// Calculate takes the information from
        /// Tipster and displays the results of the 
        /// tip.
        /// </summary>
        public Calculate()
        {
            InitializeComponent();
        }

        private void Calculation(object sender, EventArgs e)
        {
            double n1, n2, answer;

            try
            {
                n1 = Convert.ToDouble(TotalBill.Text);
                n2 = Convert.ToDouble(People.Text);
                answer = n1 / n2;
                EachPays.Text = answer.ToString();
            }
            catch
            {
                MessageBox.Show("Error in Data Entry");
            }

        }

        private void Quit(object sender, EventArgs e)
        {
            Close();
        }
    }
}
