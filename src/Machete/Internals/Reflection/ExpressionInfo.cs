namespace Machete.Internals.Reflection
{
    using System;
    using System.Linq.Expressions;
    using System.Reflection;


    /// <summary>Facade for constructing expression info.</summary>
    public abstract class ExpressionInfo
    {
        /// <summary>Expression node type.</summary>
        public abstract ExpressionType NodeType { get; }

        /// <summary>All expressions should have a Type.</summary>
        public abstract Type Type { get; }

        /// <summary>Converts back to respective expression so you may Compile it by usual means.</summary>
        public abstract Expression ToExpression();

        /// <summary>Converts to Expression and outputs its as string</summary>
        public override string ToString() => ToExpression().ToString();

        /// <summary>Analog of Expression.Parameter</summary>
        /// <remarks>For now it is return just an `Expression.Parameter`</remarks>
        public static ParameterExpressionInfo Parameter(Type type, string name = null) =>
            new ParameterExpressionInfo(type, name);

        /// <summary>Analog of Expression.Constant</summary>
        public static ConstantExpressionInfo Constant(object value, Type type = null) =>
            new ConstantExpressionInfo(value, type);

        /// <summary>Analog of Expression.New</summary>
        public static NewExpressionInfo New(ConstructorInfo ctor) =>
            new NewExpressionInfo(ctor, Tools.Empty<object>());

        /// <summary>Analog of Expression.New</summary>
        public static NewExpressionInfo New(ConstructorInfo ctor, params object[] arguments) =>
            new NewExpressionInfo(ctor, arguments);

        /// <summary>Analog of Expression.New</summary>
        public static NewExpressionInfo New(ConstructorInfo ctor, params ExpressionInfo[] arguments) =>
            new NewExpressionInfo(ctor, arguments);

        /// <summary>Static method call</summary>
        public static MethodCallExpressionInfo Call(MethodInfo method, params object[] arguments) =>
            new MethodCallExpressionInfo(null, method, arguments);

        /// <summary>Static method call</summary>
        public static MethodCallExpressionInfo Call(MethodInfo method, params ExpressionInfo[] arguments) =>
            new MethodCallExpressionInfo(null, method, arguments);

        /// <summary>Instance method call</summary>
        public static MethodCallExpressionInfo Call(
            ExpressionInfo instance, MethodInfo method, params object[] arguments) =>
            new MethodCallExpressionInfo(instance, method, arguments);

        /// <summary>Instance method call</summary>
        public static MethodCallExpressionInfo Call(
            ExpressionInfo instance, MethodInfo method, params ExpressionInfo[] arguments) =>
            new MethodCallExpressionInfo(instance, method, arguments);

        /// <summary>Static property</summary>
        public static PropertyExpressionInfo Property(PropertyInfo property) =>
            new PropertyExpressionInfo(null, property);

        /// <summary>Instance property</summary>
        public static PropertyExpressionInfo Property(ExpressionInfo instance, PropertyInfo property) =>
            new PropertyExpressionInfo(instance, property);

        /// <summary>Instance property</summary>
        public static PropertyExpressionInfo Property(object instance, PropertyInfo property) =>
            new PropertyExpressionInfo(instance, property);

        /// <summary>Static field</summary>
        public static FieldExpressionInfo Field(FieldInfo field) =>
            new FieldExpressionInfo(null, field);

        /// <summary>Instance field</summary>
        public static FieldExpressionInfo Field(ExpressionInfo instance, FieldInfo field) =>
            new FieldExpressionInfo(instance, field);

        /// <summary>Analog of Expression.Lambda</summary>
        public static LambdaExpressionInfo Lambda(ExpressionInfo body) =>
            new LambdaExpressionInfo(null, body, Tools.Empty<object>());

        /// <summary>Analog of Expression.Lambda</summary>
        public static LambdaExpressionInfo Lambda(ExpressionInfo body,
            params ParameterExpression[] parameters) =>
            new LambdaExpressionInfo(null, body, parameters);

        /// <summary>Analog of Expression.Lambda</summary>
        public static LambdaExpressionInfo Lambda(object body, params object[] parameters) =>
            new LambdaExpressionInfo(null, body, parameters);

        /// <summary>Analog of Expression.Lambda with lambda type specified</summary>
        public static LambdaExpressionInfo Lambda(Type delegateType, object body, params object[] parameters) =>
            new LambdaExpressionInfo(delegateType, body, parameters);

        /// <summary>Analog of Expression.Convert</summary>
        public static UnaryExpressionInfo Convert(ExpressionInfo operand, Type targetType) =>
            new UnaryExpressionInfo(ExpressionType.Convert, operand, targetType);

        /// <summary>Analog of Expression.Lambda</summary>
        public static ExpressionInfo<TDelegate> Lambda<TDelegate>(ExpressionInfo body) =>
            new ExpressionInfo<TDelegate>(body, Tools.Empty<ParameterExpression>());

        /// <summary>Analog of Expression.Lambda</summary>
        public static ExpressionInfo<TDelegate> Lambda<TDelegate>(ExpressionInfo body,
            params ParameterExpression[] parameters) =>
            new ExpressionInfo<TDelegate>(body, parameters);

        /// <summary>Analog of Expression.Lambda</summary>
        public static ExpressionInfo<TDelegate> Lambda<TDelegate>(ExpressionInfo body,
            params ParameterExpressionInfo[] parameters) =>
            new ExpressionInfo<TDelegate>(body, parameters);

        /// <summary>Analog of Expression.ArrayIndex</summary>
        public static BinaryExpressionInfo ArrayIndex(ExpressionInfo array, ExpressionInfo index) =>
            new ArrayIndexExpressionInfo(array, index, array.Type.GetElementType());

        /// <summary>Analog of Expression.ArrayIndex</summary>
        public static BinaryExpressionInfo ArrayIndex(object array, object index) =>
            new ArrayIndexExpressionInfo(array, index, array.GetResultType().GetElementType());

        /// <summary>Expression.Bind used in Expression.MemberInit</summary>
        public static MemberAssignmentInfo Bind(MemberInfo member, ExpressionInfo expression) =>
            new MemberAssignmentInfo(member, expression);

        /// <summary>Analog of Expression.MemberInit</summary>
        public static MemberInitExpressionInfo MemberInit(NewExpressionInfo newExpr,
            params MemberAssignmentInfo[] bindings) =>
            new MemberInitExpressionInfo(newExpr, bindings);

        /// <summary>Enables member assignment on existing instance expression.</summary>
        public static ExpressionInfo MemberInit(ExpressionInfo instanceExpr,
            params MemberAssignmentInfo[] assignments) =>
            new MemberInitExpressionInfo(instanceExpr, assignments);

        /// <summary>Constructs an array given the array type and item initializer expressions.</summary>
        public static NewArrayExpressionInfo NewArrayInit(Type type, params object[] initializers) =>
            new NewArrayExpressionInfo(type, initializers);

        /// <summary>Constructs an array given the array type and item initializer expressions.</summary>
        public static NewArrayExpressionInfo NewArrayInit(Type type, params ExpressionInfo[] initializers) =>
            new NewArrayExpressionInfo(type, initializers);

        /// <summary>Constructs assignment expression.</summary>
        public static ExpressionInfo Assign(ExpressionInfo left, ExpressionInfo right) =>
            new AssignBinaryExpressionInfo(left, right, left.Type);

        /// <summary>Constructs assignment expression from possibly mixed types of left and right.</summary>
        public static ExpressionInfo Assign(object left, object right) =>
            new AssignBinaryExpressionInfo(left, right, left.GetResultType());

        /// <summary>Invoke</summary>
        public static ExpressionInfo Invoke(ExpressionInfo lambda, params object[] args) =>
            new InvocationExpressionInfo(lambda, args, lambda.Type);
    }


    /// <summary>Typed lambda expression.</summary>
    public sealed class ExpressionInfo<TDelegate> :
        LambdaExpressionInfo
    {
        /// <summary>Type of lambda</summary>
        public Type DelegateType => Type;

        /// <inheritdoc />
        public override Expression ToExpression() => ToLambdaExpression();

        /// <summary>subject</summary>
        public new Expression<TDelegate> ToLambdaExpression() =>
            Expression.Lambda<TDelegate>(Body.ToExpression(),
                Parameters.Project(p => (ParameterExpression) p.ToExpression()));

        /// <summary>Constructor</summary>
        public ExpressionInfo(ExpressionInfo body, object[] parameters)
            : base(typeof(TDelegate), body, parameters)
        {
        }
    }
}