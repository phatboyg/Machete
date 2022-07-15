namespace Machete.Entities
{
    using System;


    public class UnbuiltEntityConverter<TEntity> :
        IEntityConverter<TEntity>
        where TEntity : Entity
    {
        readonly Lazy<IEntityConverter<TEntity>> _converter;

        public UnbuiltEntityConverter(Func<IEntityConverter<TEntity>> converterFactory, IEntitySelector entitySelector)
        {
            _converter = new Lazy<IEntityConverter<TEntity>>(converterFactory);

            EntityInfo = new UnbuiltEntityInfo(typeof(TEntity), entitySelector, _converter);
        }

        public EntityInfo EntityInfo { get; }

        public IEntityFactory Factory => _converter.Value.Factory;

        public T Convert<T>(TextSlice slice)
            where T : Entity
        {
            return _converter.Value.Convert<T>(slice);
        }

        public bool TryConvert(TextSlice slice, out Value<TEntity> convertedValue)
        {
            return _converter.Value.TryConvert(slice, out convertedValue);
        }

        public bool TryConvert(ReadOnlySpan<char> span, out Value<TEntity> convertedValue)
        {
            throw new NotImplementedException();
        }


        class UnbuiltEntityInfo :
            EntityInfo
        {
            readonly Lazy<IEntityConverter<TEntity>> _converter;

            public UnbuiltEntityInfo(Type entityType, IEntitySelector entitySelector, Lazy<IEntityConverter<TEntity>> converter, bool isDefined = true)
            {
                _converter = converter;
                EntityType = entityType;
                IsDefined = isDefined;
                EntitySelector = entitySelector;
            }

            public Type EntityType { get; }
            public bool IsDefined { get; }
            public IEntitySelector EntitySelector { get; }

            public bool TryGetValueInfo(string propertyName, out ValueInfo valueInfo)
            {
                return _converter.Value.EntityInfo.TryGetValueInfo(propertyName, out valueInfo);
            }
        }
    }
}