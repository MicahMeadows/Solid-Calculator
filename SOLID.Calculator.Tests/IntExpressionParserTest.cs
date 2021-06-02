using NUnit.Framework;
using SOLID.Calculator.Parsing;
using SOLID.Calculator.Expressions;

namespace SOLID.Calculator.Tests
{
    [TestFixture]
    class IntExpressionParserTest
    {
        private IntExpressionParser intExpressionParser;

        [SetUp]
        public void SetUp()
        {
            intExpressionParser = new IntExpressionParser();
        }

        [Test]
        public void Test_ParseExpression_StringExpression_ReturnsIntExpression()
        {
            // Given
            StringExpression stringExpression = new StringExpression { lhs = "5", rhs = "10", op = "+"};

            // When
            IntExpression intExpression = intExpressionParser.ParseExpression(stringExpression);

            // Then
            IntExpression expectedIntExpression = new IntExpression { lhs = 5, rhs = 10, op = Operator.Add };
            Assert.AreEqual(expectedIntExpression, intExpression);
        }
    }
}
