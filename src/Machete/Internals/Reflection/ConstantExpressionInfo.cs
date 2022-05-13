namespace Machete.Internals.Reflection
{
    using System;
    using System.Linq.Expressions;


    /// <summary>Analog of ConstantExpression.</summary>
    public class ConstantExpressionInfo :
        ExpressionInfo
    {
        /// <inheritdoc />
        public override ExpressionType NodeType => ExpressionType.Constant;

        /// <inheritdoc />
        public override Type Type { get; }

        /// <summary>Value of constant.</summary>
        public readonly object Value;

        /// <inheritdoc />
        public override Expression ToExpression() => Expression.Constant(Value, Type);

        /// <summary>Constructor</summary>
        public ConstantExpressionInfo(object value, Type type = null)
        {
            Value = value;
            Type = type ?? Value?.GetType() ?? typeof(object);
        }
    }
}