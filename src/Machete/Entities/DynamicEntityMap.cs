namespace Machete.Entities
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Internals.Extensions;
    using Slices;
    using Values;


    public class DynamicEntityMap<TEntity, TSchema> :
        IEntityMap<TEntity>
        where TSchema : Entity
        where TEntity : TSchema
    {
        readonly IEntityFactory<TEntity> _factory;
        readonly IEntityProperty<TEntity>[] _properties;
        readonly ITextSliceProvider<TEntity>[] _sliceProviders;

        public DynamicEntityMap(EntityType entityType, IEntityFactory<TEntity> factory, IEnumerable<IEntityProperty<TEntity>> properties, IEnumerable<ITextSliceProvider<TEntity>> fragmentProviders)
        {
            _factory = factory;

            EntityType = entityType;

            _properties = properties.ToArray();
            _sliceProviders = fragmentProviders.ToArray();
        }

        public EntityType EntityType { get; }
        IEntityFactory IEntityMap.Factory => _factory;

        public T GetEntity<T>(TextSlice slice)
            where T : Entity
        {
            if (typeof(T).IsAssignableFrom(typeof(TEntity)))
            {
                object entity = GetEntity(slice);
                return (T)entity;
            }

            throw new ArgumentException($"The type argument {TypeCache<T>.ShortName} is not assignable from the entity type ({TypeCache<TEntity>.ShortName}");
        }

        public TEntity GetEntity(TextSlice slice)
        {
            TEntity entity = _factory.Create();

            for (int i = 0; i < _properties.Length; i++)
                _properties[i].Map(entity, slice);

            return entity;
        }

        public TextSlice GetSlice(TEntity entity)
        {
            return new EntitySlice<TEntity>(entity, _sliceProviders);
        }

        public bool TryConvert(TextSlice slice, out Value<TEntity> convertedValue)
        {
            TEntity entity = _factory.Create();

            for (int i = 0; i < _properties.Length; i++)
                _properties[i].Map(entity, slice);

            convertedValue = new ConvertedValue<TEntity>(slice, entity);
            return true;
        }
    }
}