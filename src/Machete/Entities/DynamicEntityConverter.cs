namespace Machete.Entities
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Internals.Extensions;
    using Values;


    public class DynamicEntityConverter<TEntity, TSchema> :
        IEntityConverter<TEntity>
        where TSchema : Entity
        where TEntity : TSchema
    {
        readonly IEntityFactory<TEntity> _factory;
        readonly IEntityPropertyConverter<TEntity>[] _properties;

        public DynamicEntityConverter(EntityInfo entityInfo, IEntityFactory<TEntity> factory, IEnumerable<IEntityPropertyConverter<TEntity>> properties)
        {
            _factory = factory;

            EntityInfo = entityInfo;

            _properties = properties.ToArray();
        }

        public EntityInfo EntityInfo { get; }
        IEntityFactory IEntityConverter.Factory => _factory;

        public T Convert<T>(TextSlice slice)
            where T : Entity
        {
            var entity = Convert(slice);
            if (entity is T result)
                return result;

            throw new ArgumentException($"The type argument {TypeCache<T>.ShortName} is not assignable from the entity type ({TypeCache<TEntity>.ShortName}");
        }

        public bool TryConvert(TextSlice slice, out Value<TEntity> convertedValue)
        {
            var entity = Convert(slice);

            convertedValue = new ConvertedValue<TEntity>(slice.SourceText, slice.SourceSpan, entity);
            return true;
        }

        TEntity Convert(TextSlice slice)
        {
            var entity = _factory.Create();

            for (var i = 0; i < _properties.Length; i++)
                _properties[i].Convert(entity, slice);

            return entity;
        }
    }
}