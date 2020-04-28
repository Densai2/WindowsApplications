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
    /// This app allows the user to choose from a 
    /// selection of monsters and displays the 
    /// picture.
    /// </summary>
    public partial class Pictures : Form
    {
        public Pictures()
        {
            InitializeComponent();
        }

        private void MonsterSelected(object sender, EventArgs e)
        {
            if(UserChoice.Text == "Alien")
            {
                PictureChoice.Image = Image.FromFile("Alien.png");
            }
            else if (UserChoice.Text == "Banshee")
            {
                PictureChoice.Image = Image.FromFile("Banshee.jpg");
            }
            else if (UserChoice.Text == "Godzilla")
            {
                PictureChoice.Image = Image.FromFile("Godzilla.jpg");
            }
            else if (UserChoice.Text == "Mike")
            {
                PictureChoice.Image = Image.FromFile("Mike.png");
            }
            else if (UserChoice.Text == "Sid")
            {
                PictureChoice.Image = Image.FromFile("Sid.jpg");
            }
            else if (UserChoice.Text == "Zombie")
            {
                PictureChoice.Image = Image.FromFile("Zombie.png");
            }
        }

        private void Exit(object sender, EventArgs e)
        {
            Close();
        }
    }
}
