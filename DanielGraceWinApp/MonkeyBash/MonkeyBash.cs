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
    /// <summary>
    /// Monkeybash is a form which allows the user to play 
    /// a game of clicking the monkeys. It will count the 
    /// misses and hits.
    /// </summary>
    public partial class MonkeyBash : Form
    {
        private int x, y;

        private int hits, misses;

        private Random generator = new Random();

        private void Exit(object sender, EventArgs e)
        {
            Close();
        }

        private void Monkey_One(object sender, EventArgs e)
        {
            MessageBox.Show("Ouch!");
            hits = hits + 1;
        }

        private void Begin(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer2.Enabled = true;
            timer3.Enabled = true;
            timer4.Enabled = true;
        }

        private void Finish(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            timer2.Enabled = false;
            timer3.Enabled = false;
            timer4.Enabled = false;
        }

        private void PanelMiss(object sender, EventArgs e)
        {
            misses = misses + 1;
            MessageBox.Show("You MISSED!");
        }
        /// <summary>
        /// The timers will make the monkey change
        /// positions on the screen based on the 
        /// time that is input.
        /// </summary>
        private void TimerTwo(object sender, EventArgs e)
        {
            x = generator.Next(Pannel.Width - 100);
            y = generator.Next(Pannel.Height - 100);

            MonkeyTwo.Left = x;
            MonkeyTwo.Top = y;

            TotalHits.Text = "Hits = " + hits + " Misses = " + misses;

            Refresh();
        }

        private void Monkey_Two(object sender, EventArgs e)
        {
            MessageBox.Show("Ouch!");
            hits = hits + 1;
        }

        private void Monkey_Three(object sender, EventArgs e)
        {
            MessageBox.Show("Ouch!");
            hits = hits + 1;
        }

        private void Monkey_Four(object sender, EventArgs e)
        {
            MessageBox.Show("Ouch!");
            hits = hits + 1;
        }
        /// <summary>
        /// The timers will make the monkey change
        /// positions on the screen based on the 
        /// time that is input.
        /// </summary>
        private void TimerThree(object sender, EventArgs e)
        {
            x = generator.Next(Pannel.Width - 100);
            y = generator.Next(Pannel.Height - 100);

            MonkeyThree.Left = x;
            MonkeyThree.Top = y;

            TotalHits.Text = "Hits = " + hits + " Misses = " + misses;

            Refresh();
        }
        /// <summary>
        /// The timers will make the monkey change
        /// positions on the screen based on the 
        /// time that is input.
        /// </summary>
        private void TimerFour(object sender, EventArgs e)
        {
            x = generator.Next(Pannel.Width - 100);
            y = generator.Next(Pannel.Height - 100);

            MonkeyFour.Left = x;
            MonkeyFour.Top = y;

            TotalHits.Text = "Hits = " + hits + " Misses = " + misses;

            Refresh();
        }

        public MonkeyBash()
        {
            InitializeComponent();
        }

        /// <summary>
        /// The timers will make the monkey change
        /// positions on the screen based on the 
        /// time that is input.
        /// </summary>
        private void TimerOne(object sender, EventArgs e)
        {
            x = generator.Next(Pannel.Width - 100);
            y = generator.Next(Pannel.Height - 100);

            MonkeyOne.Left = x;
            MonkeyOne.Top = y;

            TotalHits.Text = "Hits = " + hits + " Misses = " + misses;

            Refresh();
        }

    }
}
