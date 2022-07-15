namespace Machete.Entities.EntityProperties
{
    using System;
    using Internals.Reflection;


    /// <summary>
    /// Maps an entity property from a single slice.
    /// </summary>
    /// <typeparam name="TEntity">The entity type</typeparam>
    /// <typeparam name="TValue">The value type</typeparam>
    public class ValueEntityPropertyConverter<TEntity, TValue> :
        IEntityPropertyConverter<TEntity>
        where TEntity : Entity
    {
        readonly ValueFactory<TValue> _valueFactory;
        readonly IWriteProperty<TEntity, Value<TValue>> _writeProperty;

        public ValueEntityPropertyConverter(string propertyName, ValueFactory<TValue> valueFactory)
        {
            _valueFactory = valueFactory;

            _writeProperty = WritePropertyCache<TEntity>.GetProperty<Value<TValue>>(propertyName);
        }

        public void Convert(TEntity entity, TextSlice slice)
        {
            var value = _valueFactory(slice);

            _writeProperty.Set(entity, value);
        }

        public void Convert(TEntity entity, ReadOnlySpan<char> span)
        {
            throw new NotImplementedException();
        }
    }
}