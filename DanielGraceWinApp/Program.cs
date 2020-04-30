using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calculation;
using DanielGraceWinApp;
using DanielGraceWinApp.PizzaShop;
using DanielGraceWinApp.MonkeyBash;
using DanielGraceWinApp.TargetPractice;
using DanielGraceWinApp.Tipster;

namespace DataEntryForm
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Calculator());
        }
    }
}
