using SOLID.Calculator.Expressions;

namespace SOLID.Calculator.Calculation
{
    public interface ICalculator
    {
        string ProcessCalculation(StringExpression expression);
    }
}
