using System;
using System.Windows.Forms;
using SOLID.Calculator.Calculation;

namespace SOLID.Calculator
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            CalculatorForm calculatorForm = new CalculatorForm();
            IntCalculator intCalculator = new IntCalculator();

            calculatorForm.calculator = intCalculator;
            Application.Run(calculatorForm);
        }
    }
}