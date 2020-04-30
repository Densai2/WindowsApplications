using System;
using System.Drawing;
using System.Windows.Forms;

namespace DanielGraceWinApp.TargetPractice
{
    /// <summary>
    /// This form has the user play a game
    /// of clicking the target, and scoring
    /// them on their accuracy.
    /// </summary>
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

        private void Close(object sender, EventArgs e)
        {
            Close();
        }

        private void Target(object sender, EventArgs e)
        {
            MessageBox.Show("Target hit!");
            hits = hits + 1;
        }
        /// <summary>
        /// This timer will decide when the target will move
        /// on the screen, depending on the seconds given.
        /// </summary>
        private void TimerOne(object sender, EventArgs e)
        {
            x = generator.Next(Pannel.Width - 100);
            y = generator.Next(Pannel.Height - 100);

            PictureTarget.Left = x;
            PictureTarget.Top = y;

            LabelTotalHits.Text = "Hits = " + hits + " Misses = " + misses;

            Refresh();
        }

        private void BackPannel(object sender, EventArgs e)
        {
            MessageBox.Show("You MISSED!");
            misses = misses + 1;
        }
        /// <summary>
        /// Depending on where the user clicks, the correct points
        /// will be issued to the user's score using x and y.
        /// </summary>
        private void MouseMovement(object sender, MouseEventArgs e)
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

            this.LabelScore.Text = score.ToString();

        }

        private void Start(object sender, EventArgs e)
        {
            Timer1.Enabled = true;
        }

        private void Stop(object sender, EventArgs e)
        {
            Timer1.Enabled = false;
        }
    }
}
