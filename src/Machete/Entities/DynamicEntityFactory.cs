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
        readonly EntityInfo _entityInfo;
        readonly Func<TEntity> _new;
        readonly WriteProperty<TEntity, EntityInfo> _entityTypeProperty;

        public DynamicEntityFactory(Type implementationType, EntityInfo entityInfo)
        {
            _entityInfo = entityInfo;
            _new = CompileNewMethod(implementationType);
            _entityTypeProperty = new WriteProperty<TEntity, EntityInfo>(implementationType, nameof(Entity.EntityInfo));
        }

        public TEntity Create()
        {
            var entity = _new();

            _entityTypeProperty.Set(entity, _entityInfo);

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