namespace Machete.PropertyMappers
{
    using System;
    using Internals;


    public class ValueListPropertyMapper<TEntity, TValue> :
        IPropertyMapper<TEntity>
        where TEntity : Entity
    {
        readonly int _position;
        readonly ValueListFactory<TValue> _valueFactory;
        readonly ValueSliceFactory _valueSliceFactory;
        readonly WriteProperty<TEntity, ValueList<TValue>> _writeProperty;

        public ValueListPropertyMapper(Type implementationType, string propertyName, int position, ValueListFactory<TValue> valueFactory, ValueSliceFactory valueSliceFactory)
        {
            _position = position;
            _valueFactory = valueFactory;
            _valueSliceFactory = valueSliceFactory;

            _writeProperty = new WriteProperty<TEntity, ValueList<TValue>>(implementationType, propertyName);
        }

        public void Map(TEntity entity, TextSlice slice)
        {
            var valueFragment = _valueSliceFactory(slice, _position);

            var value = _valueFactory(valueFragment);

            _writeProperty.Set(entity, value);
        }
    }
}