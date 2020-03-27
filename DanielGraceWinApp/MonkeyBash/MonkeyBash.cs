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
            timer2.Enabled = true;
            timer3.Enabled = true;
            timer4.Enabled = true;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            timer2.Enabled = false;
            timer3.Enabled = false;
            timer4.Enabled = false;
        }

        private void lblTotalHits_Click(object sender, EventArgs e)
        {

        }

        private void MonkeyBash_Load(object sender, EventArgs e)
        {

        }

        private void MonkeyBash_Click(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Click(object sender, EventArgs e)
        {
            misses = misses + 1;
            MessageBox.Show("You MISSED!");
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            x = generator.Next(panel1.Width - 100);
            y = generator.Next(panel1.Height - 100);

            pictureBox2.Left = x;
            pictureBox2.Top = y;

            lblTotalHits.Text = "Hits = " + hits + " Misses = " + misses;

            Refresh();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ouch!");
            hits = hits + 1;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ouch!");
            hits = hits + 1;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ouch!");
            hits = hits + 1;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            x = generator.Next(panel1.Width - 100);
            y = generator.Next(panel1.Height - 100);

            pictureBox3.Left = x;
            pictureBox3.Top = y;

            lblTotalHits.Text = "Hits = " + hits + " Misses = " + misses;

            Refresh();
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            x = generator.Next(panel1.Width - 100);
            y = generator.Next(panel1.Height - 100);

            pictureBox4.Left = x;
            pictureBox4.Top = y;

            lblTotalHits.Text = "Hits = " + hits + " Misses = " + misses;

            Refresh();
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
