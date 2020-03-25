using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DanielGraceWinApp.MonkeyBash
{
    public partial class MonkeyBash : Form
    {
        private int x, y;

        private int hits, misses;

        private Random generator = new Random();

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ouch!");
            hits = hits + 1;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void lblTotalHits_Click(object sender, EventArgs e)
        {

        }

        private void MonkeyBash_Load(object sender, EventArgs e)
        {

        }

        private void MonkeyBash_Click(object sender, EventArgs e)
        {
            misses = misses + 1;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You MISSED!");
        }

        public MonkeyBash()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            x = generator.Next(panel1.Width - 100);
            y = generator.Next(panel1.Height - 100);

            pictureBox1.Left = x;
            pictureBox1.Top = y;

            lblTotalHits.Text = "Hits = " + hits + " Misses = " + misses;

            Refresh();
        }

    }
}
