namespace Machete.Internals.Reflection
{
    using System;
    using System.Linq.Expressions;


    /// <summary>Analog of InvocationExpression.</summary>
    public sealed class InvocationExpressionInfo :
        ArgumentsExpressionInfo
    {
        /// <inheritdoc />
        public override ExpressionType NodeType => ExpressionType.Invoke;

        /// <inheritdoc />
        public override Type Type { get; }

        /// <summary>Delegate to invoke.</summary>
        public readonly ExpressionInfo ExprToInvoke;

        /// <inheritdoc />
        public override Expression ToExpression() =>
            Expression.Invoke(ExprToInvoke.ToExpression(), ArgumentsToExpressions());

        /// <summary>Constructs</summary>
        public InvocationExpressionInfo(ExpressionInfo exprToInvoke, object[] arguments, Type type) : base(arguments)
        {
            ExprToInvoke = exprToInvoke;
            Type = type;
        }
    }
}