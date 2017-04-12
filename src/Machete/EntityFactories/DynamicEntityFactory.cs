namespace Machete.EntityFactories
{
    using System;
    using System.Linq.Expressions;


    /// <summary>
    /// Creates a schema element using a dynamic implementation type
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public class DynamicEntityFactory<TEntity> :
        IEntityFactory<TEntity>
        where TEntity : Entity
    {
        readonly Func<TEntity> _new;

        public DynamicEntityFactory(Type implementationType)
        {
            _new = CompileNewMethod(implementationType);
        }

        public TEntity Create()
        {
            return _new();
        }

        public Type EntityType => typeof(TEntity);

        public T Create<T>()
            where T : Entity
        {
            var factory = this as IEntityFactory<T>;
            if (factory == null)
                throw new ArgumentException($"The specified type is invalid: {typeof(T).Name}", nameof(T));

            return factory.Create();
        }

        static Func<TEntity> CompileNewMethod(Type implementationType)
        {
            NewExpression newExpression = Expression.New(implementationType);
            Expression<Func<TEntity>> lambda = Expression.Lambda<Func<TEntity>>(newExpression);

            return lambda.Compile();
        }
    }
}