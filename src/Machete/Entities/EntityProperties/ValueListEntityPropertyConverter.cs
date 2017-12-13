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
        readonly ValueSliceFactory _valueSliceFactory;
        readonly WriteProperty<TEntity, ValueList<TValue>> _writeProperty;

        public ValueListEntityPropertyConverter(Type implementationType, string propertyName, int position, ValueListFactory<TValue> valueFactory, ValueSliceFactory valueSliceFactory)
        {
            if (implementationType == null)
                throw new ArgumentNullException(nameof(implementationType));
            if (propertyName == null)
                throw new ArgumentNullException(nameof(propertyName));

            _position = position;
            _valueFactory = valueFactory ?? throw new ArgumentNullException(nameof(valueFactory));
            _valueSliceFactory = valueSliceFactory ?? throw new ArgumentNullException(nameof(valueSliceFactory));

            _writeProperty = new WriteProperty<TEntity, ValueList<TValue>>(implementationType, propertyName);
        }

        public void Convert(TEntity entity, TextSlice slice)
        {
            var valueSlice = _valueSliceFactory(slice, _position);

            var value = _valueFactory(valueSlice);

            _writeProperty.Set(entity, value);
        }
    }
}