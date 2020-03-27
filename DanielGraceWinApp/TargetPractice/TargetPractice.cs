using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DanielGraceWinApp.TargetPractice
{
    public partial class TargetPractice : Form
    {
        private int x, y;
        double score;
        private int hits, misses;

        private Random generator = new Random();

        public TargetPractice()
        {
            InitializeComponent();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ouch!");
            hits = hits + 1;
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

        private void panel1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You MISSED!");
            misses = misses + 1;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            double x, y;
            Point mousePointerLocation = e.Location;
            x = mousePointerLocation.X;
            y = mousePointerLocation.Y;

            if (x == 50)
            {
                if (y == 50)
                {
                    MessageBox.Show("JACKPOT!!");
                    score = score + 50;
                }
            }

            else if (x <= 10 && y <= 50)
            {
                score = score + 10;
            }
            else if (x <= 50 && y <= 10)
            {
                score = score + 10;
            }
            else if (x >= 50 && y >= 10)
            {
                score = score + 20;
            }
            else if (x >= 10 && y >= 50)
            {
                score = score + 20;
            }
            else if (x > 50 && y < 10)
            {
                score = score + 10;
            }
            else if (x < 50 && y > 10)
            {
                score = score + 10;
            }
            else if (x < 50 && y > 50)
            {
                score = score + 15;
            }
            else if (x > 50 && y < 50)
            {
                score = score + 15;
            }
            else if (x > 50 && y > 50)
            {
                score = score + 15;
            }
            else
            {
                MessageBox.Show("Error");
            }

            this.lblScore.Text = score.ToString();

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }
    }
}
