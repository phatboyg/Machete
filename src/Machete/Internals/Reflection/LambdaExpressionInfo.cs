namespace Machete.Internals.Reflection
{
    using System;
    using System.Linq.Expressions;


    /// <summary>LambdaExpression</summary>
    public class LambdaExpressionInfo :
        ArgumentsExpressionInfo
    {
        /// <inheritdoc />
        public override ExpressionType NodeType => ExpressionType.Lambda;

        /// <inheritdoc />
        public override Type Type { get; }

        /// <summary>Lambda body.</summary>
        public readonly object Body;

        /// <summary>List of parameters.</summary>
        public object[] Parameters => Arguments;

        /// <inheritdoc />
        public override Expression ToExpression() => ToLambdaExpression();

        /// <summary>subject</summary>
        public LambdaExpression ToLambdaExpression() =>
            Expression.Lambda(Body.ToExpression(),
                Parameters.Project(p => (ParameterExpression)p.ToExpression()));

        /// <summary>Constructor</summary>
        public LambdaExpressionInfo(Type delegateType, object body, object[] parameters) : base(parameters)
        {
            Body = body;
            var bodyType = body.GetResultType();
            Type = delegateType != null && delegateType != typeof(Delegate)
                ? delegateType
                : Tools.GetFuncOrActionType(Tools.GetParamExprTypes(parameters), bodyType);
        }
    }
}