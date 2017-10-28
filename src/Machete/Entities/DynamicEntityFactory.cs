namespace Machete.Entities
{
    using System;
    using System.Linq.Expressions;
    using Internals.Reflection;


    /// <summary>
    /// Creates a schema element using a dynamic implementation type
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public class DynamicEntityFactory<TEntity> :
        IEntityFactory<TEntity>
        where TEntity : Entity
    {
        readonly EntityInfo _entityInfo;
        readonly WriteProperty<TEntity, EntityInfo> _entityInfoProperty;
        readonly Func<TEntity> _new;

        public DynamicEntityFactory(Type implementationType, EntityInfo entityInfo)
        {
            _entityInfo = entityInfo;

            _new = CompileNewMethod(implementationType);
            _entityInfoProperty = new WriteProperty<TEntity, EntityInfo>(implementationType, nameof(Entity.EntityInfo));
        }

        public TEntity Create()
        {
            var entity = _new();

            _entityInfoProperty.Set(entity, _entityInfo);

            return entity;
        }

        public Type EntityType => typeof(TEntity);

        static Func<TEntity> CompileNewMethod(Type implementationType)
        {
            var newExpression = Expression.New(implementationType);
            var lambda = Expression.Lambda<Func<TEntity>>(newExpression);

            return ExpressionCompiler.Compile(lambda);
        }
    }
}