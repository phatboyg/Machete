namespace Machete.Values
{
    using System;
    using System.Collections.Generic;


    public class EntityValueList<TValue> :
        ValueList<TValue>
    {
        readonly TextSlice _slice;
        readonly IValueConverter<TValue> _converter;
        readonly IList<Value<TValue>> _values;

        public EntityValueList(TextSlice slice, IValueConverter<TValue> converter)
        {
            _slice = slice;
            _converter = converter;

            _values = new List<Value<TValue>>();
        }

        Type IValue.ValueType => typeof(TValue);
        bool IValue.IsPresent => true;
        bool IValue.HasValue => true;
        TextSlice IValue.Slice => _slice;

        public Value<TValue> this[int index]
        {
            get
            {
                TryGetValue(index, out var value);

                return value;
            }
        }

        public bool TryGetValue(int index, out Value<TValue> value)
        {
            if (index < 0)
                throw new ArgumentOutOfRangeException(nameof(index), "Must be >= 0");

            if (index < _values.Count)
            {
                value = _values[index];
                return true;
            }

            TextSlice textSlice;
            for (int i = _values.Count;
                index >= _values.Count && _slice.TryGetSlice(i, out textSlice);
                i++)
            {
                _values.Add(new ConvertValue<TValue>(_slice, i, _converter));
            }

            if (index < _values.Count)
            {
                value = _values[index];
                return true;
            }

            value = Value.OutOfRange<TValue>(index, _values.Count);
            return false;
        }
    }
}