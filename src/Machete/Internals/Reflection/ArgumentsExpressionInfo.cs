namespace Machete.Internals.Reflection
{
    using System.Linq.Expressions;


    /// <summary>Base class for expressions with arguments.</summary>
    public abstract class ArgumentsExpressionInfo :
        ExpressionInfo
    {
        /// <summary>List of arguments</summary>
        public readonly object[] Arguments;

        /// <summary>Converts arguments to expressions</summary>
        protected Expression[] ArgumentsToExpressions() => Arguments.Project(Tools.ToExpression);

        /// <summary>Constructor</summary>
        protected ArgumentsExpressionInfo(object[] arguments)
        {
            Arguments = arguments ?? Tools.Empty<object>();
        }
    }
}