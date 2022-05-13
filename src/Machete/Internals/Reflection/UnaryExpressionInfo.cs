namespace Machete.Internals.Reflection
{
    using System;
    using System.Linq.Expressions;


    /// <summary>Analog of Convert expression.</summary>
    public class UnaryExpressionInfo :
        ExpressionInfo
    {
        /// <inheritdoc />
        public override ExpressionType NodeType { get; }

        /// <summary>Target type.</summary>
        public override Type Type { get; }

        /// <summary>Operand expression</summary>
        public readonly ExpressionInfo Operand;

        /// <inheritdoc />
        public override Expression ToExpression()
        {
            if (NodeType == ExpressionType.Convert)
                return Expression.Convert(Operand.ToExpression(), Type);
            throw new NotSupportedException("Cannot convert ExpressionInfo to Expression of type " + NodeType);
        }

        /// <summary>Constructor</summary>
        public UnaryExpressionInfo(ExpressionType nodeType, ExpressionInfo operand, Type type)
        {
            NodeType = nodeType;
            Operand = operand;
            Type = type;
        }
    }
}