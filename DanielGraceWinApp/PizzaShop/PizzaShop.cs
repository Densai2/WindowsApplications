using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DanielGraceWinApp.PizzaShop
{
    /// <summary>
    /// This form allows the user to choose from 
    /// different options for a pizza to then 
    /// display the cost.
    /// </summary>
    public partial class PizzaShop : Form
    {
        double toppingPrice, pizzaPrice, finalPrice;
        public PizzaShop()
        {
            InitializeComponent();
        }

        private void Pineapple_Checked(object sender, EventArgs e)
        {
            if (Pineapple.Checked)
            {
                toppingPrice = toppingPrice + 2.5;
            }
            else
            {
                toppingPrice = toppingPrice - 2.5;
            }
            finalPrice = pizzaPrice + toppingPrice;
            EndCost.Text = "£ " + finalPrice.ToString("0.00");
        }

        private void Rhubard_Checked(object sender, EventArgs e)
        {
            if (Rhubard.Checked)
            {
                toppingPrice = toppingPrice + 2.5;
            }
            else
            {
                toppingPrice = toppingPrice - 2.5;
            }
            finalPrice = pizzaPrice + toppingPrice;
            EndCost.Text = "£ " + finalPrice.ToString("0.00");
        }

        private void Large_Checked(object sender, EventArgs e)
        {
            if (Large.Checked)
            {
                pizzaPrice = 12;
            }
            finalPrice = pizzaPrice + toppingPrice;
            EndCost.Text = "£ " + finalPrice.ToString("0.00");
        }

        private void Medium_Checked(object sender, EventArgs e)
        {
            if (Medium.Checked)
            {
                pizzaPrice = 8;
            }
            finalPrice = pizzaPrice + toppingPrice;
            EndCost.Text = "£ " + finalPrice.ToString("0.00");
        }

        private void Small_Checked(object sender, EventArgs e)
        {
            if (Small.Checked)
            {
                pizzaPrice = 5;
            }
            finalPrice = pizzaPrice + toppingPrice;
            EndCost.Text = "£ " + finalPrice.ToString("0.00");
        }

        private void Pepperoni_Checked(object sender, EventArgs e)
        {
            if (Pepperoni.Checked)
            {
                toppingPrice = toppingPrice + 2.5;
            }
            else
            {
                toppingPrice = toppingPrice - 2.5;
            }
            finalPrice = pizzaPrice + toppingPrice;
            EndCost.Text = "£ " + finalPrice.ToString("0.00");
        }

        private void Chocolate_Checked(object sender, EventArgs e)
        {
            if (Chocolate.Checked)
            {
                toppingPrice = toppingPrice + 2.5;
            }
            else
            {
                toppingPrice = toppingPrice - 2.5;
            }
            finalPrice = pizzaPrice + toppingPrice;
            EndCost.Text = "£ " + finalPrice.ToString("0.00");
        }
    }
}