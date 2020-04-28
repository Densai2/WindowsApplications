using System;
using System.Windows.Forms;

namespace DanielGraceWinApp
{
    public partial class CompWins : Form
    {
        /// <summary>
        /// If the computer wins, the user is taken
        /// to this screen, clicking exits.
        /// </summary>
        public CompWins()
        {
            InitializeComponent();
        }

        private void SadFace(object sender, EventArgs e)
        {
            Close();
        }

        private void UserLoss(object sender, EventArgs e)
        {
            Close();
        }

        private void ComputerWins(object sender, EventArgs e)
        {
            Close();
        }
    }
}
