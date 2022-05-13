namespace Machete.Internals.Reflection
{
    using System;
    using System.Linq.Expressions;
    using System.Reflection;


    /// <summary>Analog of PropertyExpression</summary>
    public class FieldExpressionInfo :
        MemberExpressionInfo
    {
        /// <inheritdoc />
        public override Type Type => FieldInfo.FieldType;

        /// <summary>Subject</summary>
        public FieldInfo FieldInfo => (FieldInfo)Member;

        /// <inheritdoc />
        public override Expression ToExpression() =>
            System.Linq.Expressions.Expression.Field(Expression.ToExpression(), FieldInfo);

        /// <summary>Construct from field info</summary>
        public FieldExpressionInfo(ExpressionInfo instance, FieldInfo field)
            : base(instance, field) { }
    }
}