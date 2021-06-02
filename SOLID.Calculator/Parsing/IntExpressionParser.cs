using SOLID.Calculator.Expressions;

namespace SOLID.Calculator.Parsing
{
    public class IntExpressionParser : IExpressionParser<IntExpression>
    {
        public IntExpressionParser() { }

        public IntExpression ParseExpression(StringExpression stringExpression)
        {
            IntExpression intExpression = new IntExpression();

            int.TryParse(stringExpression.lhs, out intExpression.lhs);
            int.TryParse(stringExpression.rhs, out intExpression.rhs);
            switch (stringExpression.op)
            {
                case "*":
                    intExpression.op = Operator.Multiply;
                    break;
                case "/":
                    intExpression.op = Operator.Divide;
                    break;
                case "+":
                    intExpression.op = Operator.Add;
                    break;
                case "-":
                    intExpression.op = Operator.Subtract;
                    break;
                default:
                    intExpression.op = Operator.NoOp;
                    break;
            }
            return intExpression;

        }
    }
}
