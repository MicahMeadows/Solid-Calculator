using SOLID.Calculator.Expressions;

namespace SOLID.Calculator.Calculation
{
    public class IntResultCalculator
    {
        private IntExpression intExpression;

        public IntResultCalculator(IntExpression intExpression)
        {
            this.intExpression = intExpression;
        }

        private int Add()
        {
            return intExpression.lhs + intExpression.rhs;
        }

        private int Subtract()
        {
            return intExpression.lhs - intExpression.rhs;
        }

        private int Multiply()
        {
            return intExpression.lhs * intExpression.rhs;
        }

        private int Divide()
        {
            return intExpression.lhs / intExpression.rhs;
        }

        public int CalculateResult()
        {
            switch (this.intExpression.op)
            {
                case Operator.Add:
                    return Add();
                case Operator.Subtract:
                    return Subtract();
                case Operator.Multiply:
                    return Multiply();
                case Operator.Divide:
                    return Divide();
                default:
                    return intExpression.lhs;
            }
        }
    }
}
