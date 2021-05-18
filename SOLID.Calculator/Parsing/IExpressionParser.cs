using SOLID.Calculator.Expressions;

namespace SOLID.Calculator.Parsing
{
    public interface IExpressionParser<T>
    {
        T ParseExpression(StringExpression stringExpression);
    }
}
