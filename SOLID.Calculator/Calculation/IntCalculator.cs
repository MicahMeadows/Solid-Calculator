using SOLID.Calculator.Parsing;
using SOLID.Calculator.Expressions;
using SOLID.Calculator.Calculation;

namespace SOLID.Calculator.Calculation
{

    public class IntCalculator : ICalculator
    {
        public string ProcessCalculation(StringExpression stringExpression)
        {
            // Parse string expression into int expression
            IExpressionParser<IntExpression> expressionParser = new IntExpressionParser();
            IntExpression intExpression = expressionParser.ParseExpression(stringExpression);

            if (intExpression.rhs == 0 && intExpression.op == Operator.Divide)
                return "undefined";

            // Process result
            IntResultCalculator intResultCalculator = new IntResultCalculator(intExpression);

            return intResultCalculator.CalculateResult().ToString();
        }
    }
}
