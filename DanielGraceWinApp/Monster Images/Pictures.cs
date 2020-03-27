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
    public partial class Pictures : Form
    {
        public Pictures()
        {
            InitializeComponent();
        }

        private void CboChoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(CboChoice.Text == "Alien")
            {
                PictureChoice.Image = Image.FromFile("Alien.png");
            }
            else if (CboChoice.Text == "Banshee")
            {
                PictureChoice.Image = Image.FromFile("Banshee.jpg");
            }
            else if (CboChoice.Text == "Godzilla")
            {
                PictureChoice.Image = Image.FromFile("Godzilla.jpg");
            }
            else if (CboChoice.Text == "Mike")
            {
                PictureChoice.Image = Image.FromFile("Mike.png");
            }
            else if (CboChoice.Text == "Sid")
            {
                PictureChoice.Image = Image.FromFile("Sid.jpg");
            }
            else if (CboChoice.Text == "Zombie")
            {
                PictureChoice.Image = Image.FromFile("Zombie.png");
            }
        }

        private void Quit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
