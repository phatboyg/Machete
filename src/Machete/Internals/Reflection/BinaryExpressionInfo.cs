namespace Machete.Internals.Reflection
{
    using System;
    using System.Linq.Expressions;


    /// <summary>BinaryExpression analog.</summary>
    public abstract class BinaryExpressionInfo :
        ExpressionInfo
    {
        /// <inheritdoc />
        public override ExpressionType NodeType { get; }

        /// <inheritdoc />
        public override Type Type { get; }

        /// <summary>Left expression</summary>
        public readonly object Left;

        /// <summary>Right expression</summary>
        public readonly object Right;

        /// <summary>Constructs from left and right expressions.</summary>
        protected BinaryExpressionInfo(ExpressionType nodeType, object left, object right, Type type)
        {
            NodeType = nodeType;
            Type = type;
            Left = left;
            Right = right;
        }
    }
}