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
        public Calculate()
        {
            InitializeComponent();
        }

        private void Calculate_Load(object sender, EventArgs e)
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

        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
