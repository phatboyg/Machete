namespace Machete.Entities
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Internals.Reflection;


    /// <summary>
    /// Creates a schema element using a dynamic implementation type
    /// </summary>
    /// <typeparam name="TEntity">The entity type</typeparam>
    /// <typeparam name="TImplementation">The implementation type</typeparam>
    public class DynamicEntityFactory<TEntity, TImplementation> :
        IEntityFactory<TEntity>
        where TEntity : Entity
        where TImplementation : TEntity, new()
    {
        readonly EntityInfo _entityInfo;
        readonly WriteProperty<TEntity, EntityInfo> _entityInfoProperty;
        readonly IEntityInitializer<TEntity>[] _initializers;

        public DynamicEntityFactory(EntityInfo entityInfo, IEnumerable<IEntityInitializer<TEntity>> initializers)
        {
            _entityInfo = entityInfo;

            _initializers = initializers.ToArray();

            _entityInfoProperty = new WriteProperty<TEntity, EntityInfo>(typeof(TImplementation), nameof(Entity.EntityInfo));
        }

        public TEntity Create()
        {
            var entity = new TImplementation();

            _entityInfoProperty.Set(entity, _entityInfo);

            for (int i = 0; i < _initializers.Length; i++)
            {
                _initializers[i].Initialize(entity);
            }

            return entity;
        }

        Type IEntityFactory.EntityType => typeof(TEntity);
    }
}