namespace Machete.Entities.EntityProperties
{
    using System;
    using Internals;


    public class ValueListEntityProperty<TEntity, TValue> :
        IEntityProperty<TEntity>
        where TEntity : Entity
    {
        readonly int _position;
        readonly ValueListFactory<TValue> _valueFactory;
        readonly ValueSliceFactory _valueSliceFactory;
        readonly WriteProperty<TEntity, ValueList<TValue>> _writeProperty;

        public ValueListEntityProperty(Type implementationType, string propertyName, int position, ValueListFactory<TValue> valueFactory, ValueSliceFactory valueSliceFactory)
        {
            _position = position;
            _valueFactory = valueFactory;
            _valueSliceFactory = valueSliceFactory;

            _writeProperty = new WriteProperty<TEntity, ValueList<TValue>>(implementationType, propertyName);
        }

        public void Map(TEntity entity, TextSlice slice)
        {
            var valueSlice = _valueSliceFactory(slice, _position);

            var value = _valueFactory(valueSlice);

            _writeProperty.Set(entity, value);
        }
    }
}