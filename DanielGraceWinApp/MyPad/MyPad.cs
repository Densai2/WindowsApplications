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
    /// <summary>
    /// This form allows the user to create text
    /// document with many different features.
    /// </summary>
    public partial class MyPad : Form
    {
        public MyPad()
        {
            InitializeComponent();
        }

        private void CutText(object sender, EventArgs e)
        {
            txtMain.Cut();
        }

        private void CopyText(object sender, EventArgs e)
        {
            txtMain.Copy();
        }

        private void PasteText(object sender, EventArgs e)
        {
            txtMain.Paste();
        }

        private void UndoText(object sender, EventArgs e)
        {
            txtMain.Undo();
        }

        private void SaveFile(object sender, EventArgs e)
        {
            sfd.ShowDialog();
            txtMain.SaveFile(sfd.FileName);

        }

        private void OpenFile(object sender, EventArgs e)
        {
            txtMain.LoadFile(ofd.FileName);
        }

        private void FontChoice(object sender, EventArgs e)
        {
            fd.ShowDialog();
            txtMain.Font = fd.Font;
        }

        private void FontColour(object sender, EventArgs e)
        {
            cd.ShowDialog();
            txtMain.BackColor = cd.Color;
        }

        private void ForegroundColour(object sender, EventArgs e)
        {
            cd.ShowDialog();
            txtMain.ForeColor = cd.Color;
        }

        private void ScrollBar(object sender, ScrollEventArgs e)
        {
            Font f = new Font(txtMain.Font.Name, 20, FontStyle.Regular);
            txtMain.SelectionFont = f;
        }
    }
}
