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
    /// This is a rock, paper, scissors game. 
    /// The user and the computer will choose
    /// an option which is then displayed on 
    /// the screen, along with the result.
    /// Additionally,
    /// </summary>
    public partial class RPSGame : Form
    {
        int computerChoice, userChoice;
        int computerScore = 0;
        int playerScore = 0;

        public RPSGame()
        {
            InitializeComponent();
        }

        private void UserRock(object sender, EventArgs e)
        {
            UserPicture.Image = Image.FromFile("Rock.png");
            userChoice = 1;
        }

        private void RPSGame_Load(object sender, EventArgs e)
        {
            RPSGameOpenSplash rPSGameOpenSplash = new RPSGameOpenSplash();
            rPSGameOpenSplash.ShowDialog();
        }

        private void UserPaper(object sender, EventArgs e)
        {
            UserPicture.Image = Image.FromFile("Paper.png");
            userChoice = 2;
        }

        private void UserScissors(object sender, EventArgs e)
        {
            UserPicture.Image = Image.FromFile("Scissors.png");
            userChoice = 3;
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

        private void Exit(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PlayerScore(object sender, EventArgs e)
        {
            playerScore.ToString();
        }

        public void UserWins()
        {
            ResultText.BackColor = Color.Aqua;
            ResultText.ForeColor = Color.Orange;
            LabelUserScore.BackColor = Color.Aqua;
            LabelUserScore.ForeColor = Color.Orange;
            LabelComputerScore.BackColor = Color.Aqua;
            LabelComputerScore.ForeColor = Color.Orange;
            TextUserScore.BackColor = Color.Aqua;
            TextUserScore.ForeColor = Color.Orange;
            TextComputerScore.BackColor = Color.Aqua;
            TextComputerScore.ForeColor = Color.Orange;
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
                TextUserScore.BackColor = Color.Purple;
                TextUserScore.ForeColor = Color.Black;
                TextComputerScore.BackColor = Color.Purple;
                TextComputerScore.ForeColor = Color.Black;
            }
            
    }
}
