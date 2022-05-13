namespace Machete.Internals.Reflection
{
    using System.Linq.Expressions;
    using System.Reflection;


    /// <summary>Analog of MemberExpression</summary>
    public abstract class MemberExpressionInfo :
        ExpressionInfo
    {
        /// <inheritdoc />
        public override ExpressionType NodeType => ExpressionType.MemberAccess;

        /// <summary>Member info.</summary>
        public readonly MemberInfo Member;

        /// <summary>Instance expression, null if static.</summary>
        public readonly object Expression;

        /// <summary>Constructs with</summary>
        protected MemberExpressionInfo(object expression, MemberInfo member)
        {
            Expression = expression;
            Member = member;
        }
    }
}