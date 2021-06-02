using NUnit.Framework;
using SOLID.Calculator.Calculation;
using SOLID.Calculator.Expressions;

namespace SOLID.Calculator.Tests
{
    [TestFixture]
    public class IntResultCalculatorTest
    {
        [Test]
        public void Test_Add_FivePlusTen_EqualsFifteen()
        {
            // Given
            IntExpression intExpression = new IntExpression { lhs = 5, rhs = 10, op = Operator.Add };
            IntResultCalculator intResultCalculator = new IntResultCalculator(intExpression);

            // When
            int result = intResultCalculator.CalculateResult();

            // Then
            Assert.AreEqual(15, result);
        }

        [Test]
        public void Test_Add_NegativeFivePlusNegativeTen_EqualsNegativeFifteen()
        {
            // Given
            IntExpression intExpression = new IntExpression { lhs = -5, rhs = -10, op = Operator.Add };
            IntResultCalculator intResultCalculator = new IntResultCalculator(intExpression);

            // When
            int result = intResultCalculator.CalculateResult();

            // Then
            Assert.AreEqual(-15, result);
        }
    }
}