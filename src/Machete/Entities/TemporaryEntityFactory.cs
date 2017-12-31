namespace Machete.Entities
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Machete.Internals.Extensions;

    public class TemporaryEntityFactory<TEntity> :
        IEntityFactory<TEntity>
        where TEntity : Entity
    {
        readonly Lazy<IEntityFactory<TEntity>> _factory;
        readonly EntityInfo _entityInfo;
        readonly IEntityInitializer<TEntity>[] _initializers;

        public TemporaryEntityFactory(EntityInfo entityInfo, IEnumerable<IEntityInitializer<TEntity>> initializers)
        {
            _entityInfo = entityInfo;
            _initializers = initializers.ToArray();

            _factory = new Lazy<IEntityFactory<TEntity>>(CreateFactory);
        }

        public Type EntityType => typeof(TEntity);

        public TEntity Create(TextSlice slice = null)
        {
            return _factory.Value.Create(slice);
        }

        IEntityFactory<TEntity> CreateFactory()
        {
            var entityFactoryType = typeof(DynamicEntityFactory<,>).MakeGenericType(typeof(TEntity), TypeCache<TEntity>.ImplementationType);
            var entityFactory = (IEntityFactory<TEntity>)Activator.CreateInstance(entityFactoryType, _entityInfo, _initializers);

            return entityFactory;
        }
    }
}