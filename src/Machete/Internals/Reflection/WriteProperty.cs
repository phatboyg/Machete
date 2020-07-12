namespace Machete.Internals.Reflection
{
    using System;
    using System.Diagnostics;
    using System.Linq.Expressions;
    using System.Reflection;
    using System.Threading;
    using System.Threading.Tasks;


    public class WriteProperty<TEntity, TProperty> :
        IWriteProperty<TEntity, TProperty>
    {
        Action<TEntity, TProperty> _setMethod;

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

            void SetUsingReflection(TEntity entity, TProperty property) => setMethod.Invoke(entity, new object[] {property});

            void Initialize(TEntity entity, TProperty property)
            {
                Interlocked.Exchange(ref _setMethod, SetUsingReflection);

                SetUsingReflection(entity, property);

                Task.Factory.StartNew(() => GenerateExpressionSetMethod(implementationType, setMethod),
                    CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default);
            }

            _setMethod = Initialize;
        }

        public void Set(TEntity content, TProperty value)
        {
            _setMethod(content, value);
        }

        async Task GenerateExpressionSetMethod(Type implementationType, MethodInfo setMethod)
        {
            await Task.Yield();

            try
            {
                var fastSetMethod = CompileSetMethod(implementationType, setMethod);

                Interlocked.Exchange(ref _setMethod, fastSetMethod);
            }
            catch (Exception ex)
            {
            }
        }

        static Action<TEntity, TProperty> CompileSetMethod(Type implementationType, MethodInfo setMethod)
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
                throw new MacheteParserException($"Failed to compile SetMethod for property {setMethod.Name} on entity {typeof(TEntity).Name}", ex);
            }
        }
    }
}