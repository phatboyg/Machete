namespace Machete.Entities
{
    using System;
    using System.Linq.Expressions;
    using Internals;


    /// <summary>
    /// Creates a schema element using a dynamic implementation type
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public class DynamicEntityFactory<TEntity> :
        IEntityFactory<TEntity>
        where TEntity : Entity
    {
        readonly EntityType _entityType;
        readonly Func<TEntity> _new;
        readonly WriteProperty<TEntity, EntityType> _entityTypeProperty;

        public DynamicEntityFactory(Type implementationType, EntityType entityType)
        {
            _entityType = entityType;
            _new = CompileNewMethod(implementationType);
            _entityTypeProperty = new WriteProperty<TEntity, EntityType>(implementationType, nameof(Entity.EntityType));
        }

        public TEntity Create()
        {
            var entity = _new();

            _entityTypeProperty.Set(entity, _entityType);

            return entity;
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