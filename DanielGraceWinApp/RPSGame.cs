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
    public partial class RPSGame : Form
    {
        int computerChoice, userChoice;
        int computerScore = 0;
        int playerScore = 0;

        public RPSGame()
        {
            InitializeComponent();
        }

        private void Rock_CheckedChanged(object sender, EventArgs e)
        {
            UserPicture.Image = Image.FromFile("Rock.png");
            userChoice = 1;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
         
        }

        private void RPSGame_Load(object sender, EventArgs e)
        {
            RPSGameOpenSplash rPSGameOpenSplash = new RPSGameOpenSplash();
            rPSGameOpenSplash.ShowDialog();
        }

        private void Paper_CheckedChanged(object sender, EventArgs e)
        {
            UserPicture.Image = Image.FromFile("Paper.png");
            userChoice = 2;
        }

        private void Scissors_CheckedChanged(object sender, EventArgs e)
        {
            UserPicture.Image = Image.FromFile("Scissors.png");
            userChoice = 3;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Play_Click(object sender, EventArgs e)
        {
            ClearColor();
            ResultText.BackColor = Color.Purple;
            ResultText.ForeColor = Color.Black;
            Random r = new Random();
            computerChoice = r.Next(3) + 1;

            if(computerChoice == 1)
            {
                computerChoice = 1;
                ComputerPicture.Image = Image.FromFile("Rock.png");
            }
            else if (computerChoice == 2)
            {
                computerChoice = 2;
                ComputerPicture.Image = Image.FromFile("Paper.png");
            }
            else if (computerChoice == 3)
            {
                computerChoice = 3;
                ComputerPicture.Image = Image.FromFile("Scissors.png");
            }
            CheckResult();
        }


        private void LabelResult_Click(object sender, EventArgs e)
        {

        }

        private void Quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LabelUserScore_Click(object sender, EventArgs e)
        {
            playerScore.ToString();
        }

        private void LabelComputerScore_Click(object sender, EventArgs e)
        {

        }

        public void UserWins()
        {
            ResultText.BackColor = Color.Aqua;
            ResultText.ForeColor = Color.Orange;
            LabelUserScore.BackColor = Color.Aqua;
            LabelUserScore.ForeColor = Color.Orange;
            LabelComputerScore.BackColor = Color.Aqua;
            LabelComputerScore.ForeColor = Color.Orange;
            lblUserScore.BackColor = Color.Aqua;
            lblUserScore.ForeColor = Color.Orange;
            lblComputerScore.BackColor = Color.Aqua;
            lblComputerScore.ForeColor = Color.Orange;
        }
        public void CheckResult()
        {

            if (computerChoice == userChoice)
            {
                ResultText.Text = "It's a DRAW!!!";
                playerScore = playerScore + 1;
                computerScore = computerScore + 1;
            }
            else if(userChoice == 1 && computerChoice == 3)
            {
                ResultText.Text = "The user WINS!!!";
                UserWins();
                playerScore = playerScore + 2;
            }
            else if(userChoice == 1 && computerChoice == 2)
            {
                ResultText.Text = "The computer WINS!!!";
                computerScore = computerScore + 2;
            }
            else if(userChoice == 2 && computerChoice == 1)
            {
                ResultText.Text = "The user WINS!!!";
                UserWins();
                playerScore = playerScore + 2;
            }
            else if (userChoice == 2 && computerChoice == 3)
            {
                ResultText.Text = "The computer WINS!!!";
                computerScore = computerScore + 2;
            }
            else if (userChoice == 3 && computerChoice == 2)
            {
                ResultText.Text = "The user WINS!!!";
                UserWins();
                playerScore = playerScore + 2;
            }
            else if (userChoice == 3 && computerChoice == 1)
            {
                ResultText.Text = "The computer WINS!!!";
                computerScore = computerScore + 2;
            }
            LabelUserScore.Text = playerScore.ToString();
            LabelComputerScore.Text = computerScore.ToString();

            if (playerScore >= 20 || computerScore >= 20)
            {


                if (playerScore >= 20)
                {
                    UserWin userWin = new UserWin();
                    userWin.ShowDialog();
                    Close();
                }
                else if (computerScore >= 20)
                {
                    CompWins compWins = new CompWins();
                    compWins.ShowDialog();
                    Close();
                }
                else
                {
                    Draw draw = new Draw();
                    draw.ShowDialog();
                    Close();
                }
            }
        }

            public void ClearColor()
            {
                ResultText.BackColor = Color.Purple;
                ResultText.ForeColor = Color.Black;
                LabelUserScore.BackColor = Color.Purple;
                LabelUserScore.ForeColor = Color.Black;
                LabelComputerScore.BackColor = Color.Purple;
                LabelComputerScore.ForeColor = Color.Black;
                lblUserScore.BackColor = Color.Purple;
                lblUserScore.ForeColor = Color.Black;
                lblComputerScore.BackColor = Color.Purple;
                lblComputerScore.ForeColor = Color.Black;
            }
            
    }
}
