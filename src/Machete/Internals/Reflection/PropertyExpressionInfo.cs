namespace Machete.Internals.Reflection
{
    using System;
    using System.Linq.Expressions;
    using System.Reflection;


    /// <summary>Analog of PropertyExpression</summary>
    public class PropertyExpressionInfo :
        MemberExpressionInfo
    {
        /// <inheritdoc />
        public override Type Type => PropertyInfo.PropertyType;

        /// <summary>Subject</summary>
        public PropertyInfo PropertyInfo => (PropertyInfo)Member;

        /// <inheritdoc />
        public override Expression ToExpression() =>
            System.Linq.Expressions.Expression.Property(Expression.ToExpression(), PropertyInfo);

        /// <summary>Construct from property info</summary>
        public PropertyExpressionInfo(object instance, PropertyInfo property)
            : base(instance, property) { }
    }
}