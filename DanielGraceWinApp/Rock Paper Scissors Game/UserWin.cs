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
    public partial class UserWin : Form
    {
        /// <summary>
        /// If the user wins, they are taken
        /// to this screen, clicking exits.
        /// </summary>
  
        public UserWin()
        {
            InitializeComponent();
        }

        private void UserWon(object sender, EventArgs e)
        {
            Close();
        }

        private void YouWin(object sender, EventArgs e)
        {
            Close();
        }

        private void HappyFace(object sender, EventArgs e)
        {
            Close();
        }
    }
}
