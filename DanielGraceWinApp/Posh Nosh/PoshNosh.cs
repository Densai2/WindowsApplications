﻿using System;
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
    /// This app gives the user different options
    /// and displays the total cost when selected.
    /// </summary>
    public partial class PoshNosh : Form
    {
        double maincoursecost, dessertcost, startercost, totalcost;
        public PoshNosh()
        {
            InitializeComponent();
        }


        private void Close(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// User chooses a desert from the cases,
        /// and from that the price will change.
        /// </summary>
        private void DessertChoice(object sender, EventArgs e)
        {
            switch (Deserts.Text)
            {
                case "Chocolate Fudge": dessertcost = 6.63; break;
                case "Custard": dessertcost = 13.00; break;
                case "Selection of Cheese": dessertcost = 9.32; break;
                case "Blueberry Muffin": dessertcost = 6.69; break;
            }
            totalcost = startercost + maincoursecost + dessertcost;
            FinalCost.Text = "£ " + totalcost.ToString("0.00");
        }
        /// <summary>
        /// User chooses a starter from the cases,
        /// and from that the price will change.
        /// </summary>
        private void StarterChoice(object sender, EventArgs e)
        {
            switch (Starters.Text)
            {
                case "Dough Balls": startercost = 6.25; break;
                case "Garlic Bread": startercost = 7.00; break;
                case "Prawns": startercost = 10.00; break;
                case "Soup of the day": startercost = 12.12; break;
            }
            totalcost = startercost + maincoursecost + dessertcost;
            FinalCost.Text = "£ " + totalcost.ToString("0.00");
        }
        /// <summary>
        /// User chooses a main from the cases,
        /// and from that the price will change.
        /// </summary>
        private void MainChoice(object sender, EventArgs e)
        {
            switch (Mains.Text)
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
