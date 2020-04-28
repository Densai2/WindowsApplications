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
    public partial class Draw : Form
    {
        /// <summary>
        /// This splash screen is when both sides
        /// draw, allowing them to exit once clicked.
        /// </summary>
        public Draw()
        {
            InitializeComponent();
        }

        private void FrownFace(object sender, EventArgs e)
        {
            Close();
        }

        private void Drew(object sender, EventArgs e)
        {
            Close();
        }

        private void Drawn(object sender, EventArgs e)
        {
            Close();
        }
    }
}
