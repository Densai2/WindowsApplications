using System;
using System.Windows.Forms;

namespace DanielGraceWinApp.Tipster
{
    public partial class Tipster : Form
    {
        public Tipster()
        {
            InitializeComponent();
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            Convert.ToString(Bill.Text);
            Convert.ToString(NumberPeople.Text);
            Calculate Results = new Calculate();
            Results.People.Text = NumberPeople.Text;
            Results.TotalBill.Text = Bill.Text;
            this.NumberPeople.Text = "";
            this.Bill.Focus();
            Results.Show();


        }

        private void Close(object sender, EventArgs e)
        {
            Close();
        }


        private void NormalTip(object sender, EventArgs e)
        {
            Convert.ToDouble(Bill.Text);
            double newtotal, billnum;
            billnum = Convert.ToDouble(Bill.Text);
            newtotal = billnum * 0.10;
            newtotal = newtotal + billnum;
            Bill.Text = newtotal.ToString();
        }

        private void GenerousTip(object sender, EventArgs e)
        {
            Convert.ToDouble(Bill.Text);
            double newtotal, billnum;
            billnum = Convert.ToDouble(Bill.Text);
            newtotal = billnum * 0.35;
            newtotal = newtotal + billnum;
            Bill.Text = newtotal.ToString();
        }

        private void MadTip(object sender, EventArgs e)
        {
            Convert.ToDouble(Bill.Text);
            double newtotal, billnum;
            billnum = Convert.ToDouble(Bill.Text);
            newtotal = billnum * 0.50;
            newtotal = newtotal + billnum;
            Bill.Text = newtotal.ToString();
        }
    }
}
