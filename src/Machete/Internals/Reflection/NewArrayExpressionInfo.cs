namespace Machete.Internals.Reflection
{
    using System;
    using System.Linq.Expressions;


    /// <summary>NewArrayExpression</summary>
    public class NewArrayExpressionInfo :
        ArgumentsExpressionInfo
    {
        /// <inheritdoc />
        public override ExpressionType NodeType => ExpressionType.NewArrayInit;

        /// <inheritdoc />
        public override Type Type { get; }

        /// <inheritdoc />
        public override Expression ToExpression() =>
            Expression.NewArrayInit(_elementType, ArgumentsToExpressions());

        /// <summary>Array type and initializer</summary>
        public NewArrayExpressionInfo(Type elementType, object[] elements) : base(elements)
        {
            Type = elementType.MakeArrayType();
            _elementType = elementType;
        }

        private readonly Type _elementType;
    }
}