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
    public partial class MyPad : Form
    {
        public MyPad()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtMain.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtMain.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtMain.Paste();
        }

        private void MyPad_Load(object sender, EventArgs e)
        {

        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtMain.Undo();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sfd.ShowDialog();
            txtMain.SaveFile(sfd.FileName);

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtMain.LoadFile(ofd.FileName);
        }

        private void fd_Apply(object sender, EventArgs e)
        {

        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fd.ShowDialog();
            txtMain.Font = fd.Font;
        }

        private void backgroundColourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cd.ShowDialog();
            txtMain.BackColor = cd.Color;
        }

        private void foregroundColourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cd.ShowDialog();
            txtMain.ForeColor = cd.Color;
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            Font f = new Font(txtMain.Font.Name, 20, FontStyle.Regular);
            txtMain.SelectionFont = f;
        }
    }
}
