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
    public partial class RPSGameOpenSplash : Form
    {
        /// <summary>
        /// Once RPS game has been started, this
        /// splash screen will display to welcome.
        /// </summary>
        public RPSGameOpenSplash()
        {
            InitializeComponent();
        }

        private void RPSGame_OpenSplash(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ImageRock(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ImagePaper(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ImageScissors(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
