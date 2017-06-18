namespace Machete.Internals.Reflection
{
    using System;
    using System.Linq.Expressions;
    using System.Reflection;


    public class WriteProperty<TEntity, TProperty>
    {
        readonly Action<TEntity, TProperty> _setMethod;

        public WriteProperty(Type implementationType, string propertyName)
        {
            if (typeof(TEntity).GetTypeInfo().IsValueType)
                throw new ArgumentException("The entity type must be a reference type");

            var propertyInfo = implementationType.GetProperty(propertyName);
            if (propertyInfo == null)
                throw new ArgumentException("The implementation does not have a property named: " + propertyName);

            var setMethod = propertyInfo.GetSetMethod(true);
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
                var instance = Expression.Parameter(typeof(TEntity), "instance");
                var value = Expression.Parameter(typeof(TProperty), "value");
                var cast = Expression.TypeAs(instance, implementationType);

                var call = Expression.Call(cast, setMethod, value);

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