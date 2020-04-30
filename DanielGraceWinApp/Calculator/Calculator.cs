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
    /// <summary>
    /// This form is a calcuator and allows the user to 
    /// add, subtract, divide, mulitply and average
    /// any numbers they put in.
    /// </summary>
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Exits the program with a dialog box.
        /// </summary>
        private void ExitButton(object sender, EventArgs e)
        {
            CalculatorEndScreen calculatorEnd = new CalculatorEndScreen();
            calculatorEnd.ShowDialog();
            calculatorEnd.Close();
            Application.Exit();
        }

        private void Addition(object sender, EventArgs e)
        {
            Double number1, number2, answer;
            number1 = Convert.ToDouble(FirstNumber.Text);
            number2 = Convert.ToDouble(SecondNumber.Text);
            answer = number1 + number2;
            ResultNumber.Text = answer.ToString(); 
        }

        private void Subtraction(object sender, EventArgs e)
        {
            Double number1, number2, answer;
            number1 = Convert.ToDouble(FirstNumber.Text);
            number2 = Convert.ToDouble(SecondNumber.Text);
            answer = number1 - number2;
            ResultNumber.Text = answer.ToString();
        }

        private void Multiplication(object sender, EventArgs e)
        {
            Double number1, number2, answer;
            number1 = Convert.ToDouble(FirstNumber.Text);
            number2 = Convert.ToDouble(SecondNumber.Text);
            answer = number1 * number2;
            ResultNumber.Text = answer.ToString();
        }
        /// <summary>
        /// Divides the input, and if the input is 
        /// 0 then a message box will appear.
        /// </summary>
        private void Divide(object sender, EventArgs e)
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

        private void Power(object sender, EventArgs e)
        {
            Double number1, number2, answer;
            number1 = Convert.ToDouble(FirstNumber.Text);
            number2 = Convert.ToDouble(SecondNumber.Text);
            answer = Math.Pow(number1, number2);
            ResultNumber.Text = answer.ToString();
        }

        private void Averages(object sender, EventArgs e)
        {
            Double number1, number2, answer;
            number1 = Convert.ToDouble(FirstNumber.Text);
            number2 = Convert.ToDouble(SecondNumber.Text);
            answer = (number1 + number2) / 2;
            ResultNumber.Text = answer.ToString();
        }

        private void ClearNumbers(object sender, EventArgs e)
        {
            FirstNumber.Text = "";
            SecondNumber.Text = "";
            ResultNumber.Text = "";

        }
        
    }
}
