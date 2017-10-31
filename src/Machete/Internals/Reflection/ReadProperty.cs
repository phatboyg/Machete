namespace Machete.Internals.Reflection
{
    using System;
    using System.Linq.Expressions;
    using System.Reflection;


    public class ReadProperty<TEntity, TProperty>
    {
        readonly Func<TEntity, TProperty> _getMethod;

        public ReadProperty(Type implementationType, string propertyName)
        {
            if (typeof(TEntity).GetTypeInfo().IsValueType)
                throw new ArgumentException("The entity type must be a reference type");

            var propertyInfo = implementationType.GetProperty(propertyName);
            if (propertyInfo == null)
                throw new ArgumentException("The implementation does not have a property named: " + propertyName);

            var getMethod = propertyInfo.GetGetMethod(true);
            if (getMethod == null)
                throw new ArgumentException("The property does not have an accessible get method");

            _getMethod = CompileGetMethod(implementationType, propertyInfo.Name, getMethod);
        }

        public TProperty Get(TEntity content)
        {
            return _getMethod(content);
        }

        static Func<TEntity, TProperty> CompileGetMethod(Type implementationType, string propertyName, MethodInfo getMethod)
        {
            try
            {
                var instance = Expression.Parameter(typeof(TEntity), "instance");
                var cast = Expression.TypeAs(instance, implementationType);

                var call = Expression.Call(cast, getMethod);

                var lambdaExpression = Expression.Lambda<Func<TEntity, TProperty>>(call, instance);

                return ExpressionCompiler.Compile<Func<TEntity, TProperty>>(lambdaExpression);
            }
            catch (Exception ex)
            {
                throw new MacheteParserException($"Failed to compile get method for property {propertyName} on content {typeof(TEntity).Name}", ex);
            }
        }
    }
}