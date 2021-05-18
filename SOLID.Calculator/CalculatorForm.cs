using SOLID.Calculator.Expressions;
using SOLID.Calculator.Calculation;

namespace SOLID.Calculator
{
    public partial class CalculatorForm : Form
    {
        public Action pressedEqualsButton;

        public ICalculator calculator;

        private string lhsText = "";
        private string rhsText = "";
        private string operatorText = null;

        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void Reset()
        {
            lhsText = "";
            rhsText = "";
            operatorText = null;
            DisplayTextBox.Text = "";
        }

        private void Submit()
        {
            StringExpression stringExpression = new StringExpression { lhs = lhsText, rhs = rhsText, op = operatorText };

            string result = calculator.ProcessCalculation(stringExpression);

            Reset();

            DisplayTextBox.Text = result;

            lhsText = result;

            if (result == "undefined")
                MessageBox.Show("Cannot divide by zero");
        }

        private void NumberButton_Click(object sender, EventArgs e)
        {
            Button numberButton = sender as Button;
            if (numberButton == null) return;

            if (operatorText == null)
            {
                lhsText += numberButton.Text;
                DisplayTextBox.Text = lhsText;
            }
            else
            {
                rhsText += numberButton.Text;
                DisplayTextBox.Text = lhsText + " " + operatorText + " " + rhsText;
            }
            
        }
        private void OperatorButton_Click(object sender, EventArgs e)
        {
            Button operatorButton = sender as Button;
            if (operatorButton == null) return;

            if (operatorText != null)
                Submit();

            operatorText = operatorButton.Text;
            DisplayTextBox.Text = lhsText + " " + operatorText + " " + rhsText;
        }
        private void ClearButton_Click(object sender, EventArgs e)
        {
            Reset();
        }
        private void EqualButton_Click(object sender, EventArgs e)
        {
            Submit();
        }
    }
}