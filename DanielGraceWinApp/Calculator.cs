using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DanielGraceWinApp;

namespace Calculation
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            CalculatorEndScreen calculatorEnd = new CalculatorEndScreen();
            calculatorEnd.ShowDialog();
            calculatorEnd.Close();
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            Double number1, number2, answer;
            number1 = Convert.ToDouble(FirstNumber.Text);
            number2 = Convert.ToDouble(SecondNumber.Text);
            answer = number1 + number2;
            ResultNumber.Text = answer.ToString(); 
        }

        private void FirstNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void SecondNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void Subtract_Click(object sender, EventArgs e)
        {
            Double number1, number2, answer;
            number1 = Convert.ToDouble(FirstNumber.Text);
            number2 = Convert.ToDouble(SecondNumber.Text);
            answer = number1 - number2;
            ResultNumber.Text = answer.ToString();
        }

        private void Muliply_Click(object sender, EventArgs e)
        {
            Double number1, number2, answer;
            number1 = Convert.ToDouble(FirstNumber.Text);
            number2 = Convert.ToDouble(SecondNumber.Text);
            answer = number1 * number2;
            ResultNumber.Text = answer.ToString();
        }

        private void Devision_Click(object sender, EventArgs e)
        {
            Double number1, number2, answer;
            number1 = Convert.ToDouble(FirstNumber.Text);
            number2 = Convert.ToDouble(SecondNumber.Text);
            if (number1 == 0 || number2 == 0)
            {
                MessageBox.Show("You should NOT divide by ZERO!");
            }
            else
            {
                answer = number1 / number2;
                ResultNumber.Text = answer.ToString();
            }
        }

        private void Calculator_Load(object sender, EventArgs e)
        {
            SplashCalculator splashcalculator = new SplashCalculator();
            splashcalculator.ShowDialog();
            splashcalculator.Close();
        }

        private void PowerOf_Click(object sender, EventArgs e)
        {
            Double number1, number2, answer;
            number1 = Convert.ToDouble(FirstNumber.Text);
            number2 = Convert.ToDouble(SecondNumber.Text);
            answer = Math.Pow(number1, number2);
            ResultNumber.Text = answer.ToString();
        }

        private void Average_Click(object sender, EventArgs e)
        {
            Double number1, number2, answer;
            number1 = Convert.ToDouble(FirstNumber.Text);
            number2 = Convert.ToDouble(SecondNumber.Text);
            answer = (number1 + number2) / 2;
            ResultNumber.Text = answer.ToString();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            FirstNumber.Text = "";
            SecondNumber.Text = "";
            ResultNumber.Text = "";

        }
    }
}
