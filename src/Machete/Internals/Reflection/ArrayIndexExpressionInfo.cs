namespace Machete.Internals.Reflection
{
    using System;
    using System.Linq.Expressions;


    /// <summary>Expression.ArrayIndex </summary>
    public class ArrayIndexExpressionInfo :
        BinaryExpressionInfo
    {
        /// <summary>Constructor</summary>
        public ArrayIndexExpressionInfo(object left, object right, Type type)
            : base(ExpressionType.ArrayIndex, left, right, type) { }

        /// <inheritdoc />
        public override Expression ToExpression() =>
            Expression.ArrayIndex(Left.ToExpression(), Right.ToExpression());
    }
}