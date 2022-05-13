namespace Machete.Internals.Reflection
{
    using System;
    using System.Linq.Expressions;


    /// <summary>Expression.Assign </summary>
    public class AssignBinaryExpressionInfo :
        BinaryExpressionInfo
    {
        /// <summary>Constructor</summary>
        public AssignBinaryExpressionInfo(object left, object right, Type type)
            : base(ExpressionType.Assign, left, right, type) { }

        /// <inheritdoc />
        public override Expression ToExpression() =>
            Expression.Assign(Left.ToExpression(), Right.ToExpression());
    }
}