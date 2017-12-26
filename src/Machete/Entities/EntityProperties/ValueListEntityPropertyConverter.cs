namespace Machete.Entities.EntityProperties
{
    using System;
    using Internals.Reflection;


    public class ValueListEntityPropertyConverter<TEntity, TValue> :
        IEntityPropertyConverter<TEntity>
        where TEntity : Entity
    {
        readonly int _position;
        readonly ValueListFactory<TValue> _valueFactory;
        readonly ValueSliceProvider _valueSliceProvider;
        readonly IWriteProperty<TEntity, ValueList<TValue>> _writeProperty;

        public ValueListEntityPropertyConverter(Type implementationType, string propertyName, int position, ValueListFactory<TValue> valueFactory,
            ValueSliceProvider valueSliceProvider)
        {
            if (implementationType == null)
                throw new ArgumentNullException(nameof(implementationType));
            if (propertyName == null)
                throw new ArgumentNullException(nameof(propertyName));

            _position = position;
            _valueFactory = valueFactory ?? throw new ArgumentNullException(nameof(valueFactory));
            _valueSliceProvider = valueSliceProvider ?? throw new ArgumentNullException(nameof(valueSliceProvider));

            _writeProperty = WritePropertyCache<TEntity>.GetProperty<ValueList<TValue>>(propertyName);
        }

        public void Convert(TEntity entity, TextSlice slice)
        {
            var valueSlice = _valueSliceProvider(slice, _position);

            var value = _valueFactory(valueSlice);

            _writeProperty.Set(entity, value);
        }
    }
}