namespace Machete.Internals.Reflection
{
    using System;
    using System.Linq.Expressions;


    /// <summary>Wraps ParameterExpression and just it.</summary>
    public class ParameterExpressionInfo :
        ExpressionInfo
    {
        /// <inheritdoc />
        public override ExpressionType NodeType => ExpressionType.Parameter;

        /// <inheritdoc />
        public override Type Type { get; }

        /// <inheritdoc />
        public override Expression ToExpression() => ParamExpr;

        /// <summary>Wrapped parameter expression.</summary>
        public ParameterExpression ParamExpr =>
            _parameter ?? (_parameter = Expression.Parameter(Type, Name));

        /// <summary>Allow to change parameter expression as info interchangeable.</summary>
        public static implicit operator ParameterExpression(ParameterExpressionInfo info) => info.ParamExpr;

        /// <summary>Optional name.</summary>
        public readonly string Name;

        /// <summary>Creates a thing.</summary>
        public ParameterExpressionInfo(Type type, string name)
        {
            Type = type;
            Name = name;
        }

        /// <summary>Constructor</summary>
        public ParameterExpressionInfo(ParameterExpression paramExpr)
            : this(paramExpr.Type, paramExpr.Name)
        {
            _parameter = paramExpr;
        }

        private ParameterExpression _parameter;
    }
}