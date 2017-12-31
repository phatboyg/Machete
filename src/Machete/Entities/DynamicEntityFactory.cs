namespace Machete.Entities
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Internals.Reflection;
    using Machete.Internals.Extensions;


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
        readonly IWriteProperty<TEntity, EntityInfo> _entityInfoProperty;
        readonly IWriteProperty<TEntity, TextSlice> _textSliceProperty;
        readonly IEntityInitializer<TEntity>[] _initializers;

        public DynamicEntityFactory(EntityInfo entityInfo, IEnumerable<IEntityInitializer<TEntity>> initializers)
        {
            _entityInfo = entityInfo;

            _initializers = initializers.ToArray();

            _entityInfoProperty = WritePropertyCache<TEntity>.GetProperty<EntityInfo>(nameof(Entity.EntityInfo));
            _textSliceProperty = WritePropertyCache<TEntity>.GetProperty<TextSlice>(nameof(Entity.ParsedText));
        }

        public TEntity Create(TextSlice slice)
        {
            var entity = new TImplementation();

            _entityInfoProperty.Set(entity, _entityInfo);
            _textSliceProperty.Set(entity, slice ?? Slice.Empty);

            for (int i = 0; i < _initializers.Length; i++)
            {
                _initializers[i].Initialize(entity);
            }

            return entity;
        }

        Type IEntityFactory.EntityType => typeof(TEntity);
    }
}