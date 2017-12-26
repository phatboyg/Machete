namespace Machete.Internals.Reflection
{
    using System;
    using System.Diagnostics;
    using System.Linq.Expressions;
    using System.Reflection;
    using System.Threading;
    using System.Threading.Tasks;


    public class ReadProperty<TEntity, TProperty> :
        IReadProperty<TEntity, TProperty>
    {
        Func<TEntity, TProperty> _getMethod;

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

            TProperty GetUsingReflection(TEntity entity) => (TProperty) getMethod.Invoke(entity, null);

            TProperty Initialize(TEntity entity)
            {
                Interlocked.Exchange(ref _getMethod, GetUsingReflection);

                Task.Factory.StartNew(() => GenerateExpressionGetMethod(implementationType, propertyName, getMethod),
                    CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default);

                return GetUsingReflection(entity);
            }

            _getMethod = Initialize;
        }

        public TProperty Get(TEntity content)
        {
            return _getMethod(content);
        }

        async Task GenerateExpressionGetMethod(Type implementationType, string propertyName, MethodInfo getMethod)
        {
            await Task.Yield();

            try
            {
                var method = CompileGetMethod(implementationType, propertyName, getMethod);

                Interlocked.Exchange(ref _getMethod, method);
            }
            catch (Exception ex)
            {
#if !NETCORE
                if (Trace.Listeners.Count > 0)
                    Trace.WriteLine(ex.Message);
#endif
            }
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
                throw new MacheteParserException($"Failed to compile get method for property {propertyName} on entity {typeof(TEntity).Name}", ex);
            }
        }
    }
}