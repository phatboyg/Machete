namespace Machete.Internals.Reflection
{
    using System;
    using System.Linq.Expressions;
    using System.Reflection;


    /// <summary>Analog of NewExpression</summary>
    public class NewExpressionInfo :
        ArgumentsExpressionInfo
    {
        /// <inheritdoc />
        public override ExpressionType NodeType => ExpressionType.New;

        /// <inheritdoc />
        public override Type Type => Constructor.DeclaringType;

        /// <summary>The constructor info.</summary>
        public readonly ConstructorInfo Constructor;

        /// <inheritdoc />
        public override Expression ToExpression() => ToNewExpression();

        /// <summary>Converts to NewExpression</summary>
        public NewExpression ToNewExpression() => Expression.New(Constructor, ArgumentsToExpressions());

        /// <summary>Construct from constructor info and argument expressions</summary>
        public NewExpressionInfo(ConstructorInfo constructor, params object[] arguments) : base(arguments)
        {
            Constructor = constructor;
        }
    }
}