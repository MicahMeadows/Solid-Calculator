namespace SOLID.Calculator.Expressions
{
    public class IntExpression
    {
        public int lhs;
        public int rhs;
        public Operator op;

        public override bool Equals(object obj)
        {
            var toCompare = obj as IntExpression;
            if (toCompare == null)
                return false;

            return toCompare.lhs == this.lhs && toCompare.rhs == this.rhs && toCompare.op == this.op;
        }
    }
}
