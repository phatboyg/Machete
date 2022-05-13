namespace Machete.Internals.Reflection
{
    using System;
    using System.Linq.Expressions;
    using System.Reflection;


    /// <summary>Analog of MethodCallExpression</summary>
    public class MethodCallExpressionInfo :
        ArgumentsExpressionInfo
    {
        /// <inheritdoc />
        public override ExpressionType NodeType => ExpressionType.Call;

        /// <inheritdoc />
        public override Type Type => Method.ReturnType;

        /// <summary>The method info.</summary>
        public readonly MethodInfo Method;

        /// <summary>Instance expression, null if static.</summary>
        public readonly ExpressionInfo Object;

        /// <inheritdoc />
        public override Expression ToExpression() =>
            Expression.Call(Object?.ToExpression(), Method, ArgumentsToExpressions());

        /// <summary>Construct from method info and argument expressions</summary>
        public MethodCallExpressionInfo(ExpressionInfo @object, MethodInfo method, params object[] arguments)
            : base(arguments)
        {
            Object = @object;
            Method = method;
        }
    }
}