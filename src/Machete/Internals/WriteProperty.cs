namespace Machete.Internals
{
    using System;
    using System.Linq.Expressions;
    using System.Reflection;
    using Reflection;


    public class WriteProperty<TEntity, TProperty>
    {
        readonly Action<TEntity, TProperty> _setMethod;

        public WriteProperty(Type implementationType, string propertyName)
        {
            if (typeof(TEntity).IsValueType)
                throw new ArgumentException("The entity type must be a reference type");

            PropertyInfo propertyInfo = implementationType.GetProperty(propertyName);
            if (propertyInfo == null)
                throw new ArgumentException("The implementation does not have a property named: " + propertyName);

            MethodInfo setMethod = propertyInfo.GetSetMethod(true);
            if (setMethod == null)
                throw new ArgumentException("The property does not have an accessible set method");

            _setMethod = CompileSetMethod(implementationType, propertyInfo.Name, setMethod);
        }

        public void Set(TEntity content, TProperty value)
        {
            _setMethod(content, value);
        }

        static Action<TEntity, TProperty> CompileSetMethod(Type implementationType, string propertyName, MethodInfo setMethod)
        {
            try
            {
                ParameterExpression instance = Expression.Parameter(typeof(TEntity), "instance");
                ParameterExpression value = Expression.Parameter(typeof(TProperty), "value");
                UnaryExpression cast = Expression.TypeAs(instance, implementationType);

                MethodCallExpression call = Expression.Call(cast, setMethod, value);

                var lambdaExpression = Expression.Lambda<Action<TEntity, TProperty>>(call, instance, value);

                return ExpressionCompiler.Compile<Action<TEntity, TProperty>>(lambdaExpression);
            }
            catch (Exception ex)
            {
                throw new MacheteParserException($"Failed to compile set method for property {propertyName} on content {typeof(TEntity).Name}", ex);
            }
        }
    }
}