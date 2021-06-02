using NUnit.Framework;
using SOLID.Calculator.Calculation;
using SOLID.Calculator.Expressions;

namespace SOLID.Calculator.Tests
{
    [TestFixture]
    class IntCalculatorTest
    {
        [Test]
        public void Test_ProcessCalculation_LhsFiveRhsFiveOperatorPlus_ReturnsTenAsString()
        {
            // Given
            StringExpression stringExpression = new StringExpression { lhs = "5", rhs = "5", op = "+" };
            IntCalculator intCalculator = new IntCalculator();

            // When
            string result = intCalculator.ProcessCalculation(stringExpression);

            // Then
            Assert.AreEqual("10", result);
        }
    }
}
