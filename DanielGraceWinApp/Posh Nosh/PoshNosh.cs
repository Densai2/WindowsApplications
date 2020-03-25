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
    public partial class PoshNosh : Form
    {
        double maincoursecost, dessertcost, startercost, totalcost;
        public PoshNosh()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lstDessert_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (lstDessert.Text)
            {
                case "Chocolate Fudge": dessertcost = 6.63; break;
                case "Custard": dessertcost = 13.00; break;
                case "Selection of Cheese": dessertcost = 9.32; break;
                case "Blueberry Muffin": dessertcost = 6.69; break;
            }
            totalcost = startercost + maincoursecost + dessertcost;
            FinalCost.Text = "£ " + totalcost.ToString("0.00");
        }

        private void FinalCost_Click(object sender, EventArgs e)
        {
            
        }

        private void lstStarter_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (lstStarter.Text)
            {
                case "Dough Balls": startercost = 6.25; break;
                case "Garlic Bread": startercost = 7.00; break;
                case "Prawns": startercost = 10.00; break;
                case "Soup of the day": startercost = 12.12; break;
            }
            totalcost = startercost + maincoursecost + dessertcost;
            FinalCost.Text = "£ " + totalcost.ToString("0.00");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (lstMain.Text)
            {
                case "Steak and Chips": maincoursecost = 12.50; break;
                case "Fish and Chips": maincoursecost = 7.50; break;
                case "Vegetable Curry": maincoursecost = 8.00; break;
                case "Chicken Lasagne": maincoursecost = 7.25; break;
            }
            totalcost = startercost + maincoursecost + dessertcost;
            FinalCost.Text = "£ " + totalcost.ToString("0.00");

        }
    }
}
