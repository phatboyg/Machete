namespace Machete.Entities.EntityProperties
{
    using System;
    using Internals.Reflection;
    using Slices;


    /// <summary>
    /// Maps an entity property from a single slice
    /// </summary>
    /// <typeparam name="TEntity">The entity type</typeparam>
    /// <typeparam name="TValue">The value type</typeparam>
    public class ValueEntityPropertyConverter<TEntity, TValue> :
        IEntityPropertyConverter<TEntity>
        where TEntity : Entity
    {
        readonly int _position;
        readonly ValueFactory<TValue> _valueFactory;
        readonly WriteProperty<TEntity, Value<TValue>> _writeProperty;

        public ValueEntityPropertyConverter(Type implementationType, string propertyName, int position, ValueFactory<TValue> valueFactory)
        {
            _position = position;
            _valueFactory = valueFactory;

            _writeProperty = new WriteProperty<TEntity, Value<TValue>>(implementationType, propertyName);
        }

        public void Convert(TEntity entity, TextSlice slice)
        {
            var value = new SinglePositionSliceValue<TValue>(slice, _position, _valueFactory);

            _writeProperty.Set(entity, value);
        }
    }
}