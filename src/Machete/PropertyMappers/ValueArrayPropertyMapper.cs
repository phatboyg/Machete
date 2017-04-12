namespace Machete.PropertyMappers
{
    using System;
    using Internals;


    public class ValueArrayPropertyMapper<TEntity, TValue> :
        IPropertyMapper<TEntity>
        where TEntity : Entity
    {
        readonly int _position;
        readonly ValueArrayFactory<TValue> _valueFactory;
        readonly ValueSliceFactory _valueSliceFactory;
        readonly WriteProperty<TEntity, ValueArray<TValue>> _writeProperty;

        public ValueArrayPropertyMapper(Type implementationType, string propertyName, int position, ValueArrayFactory<TValue> valueFactory, ValueSliceFactory valueSliceFactory)
        {
            _position = position;
            _valueFactory = valueFactory;
            _valueSliceFactory = valueSliceFactory;

            _writeProperty = new WriteProperty<TEntity, ValueArray<TValue>>(implementationType, propertyName);
        }

        public void Map(TEntity entity, TextSlice slice)
        {
            var valueFragment = _valueSliceFactory(slice, _position);

            var value = _valueFactory(valueFragment);

            _writeProperty.Set(entity, value);
        }
    }
}