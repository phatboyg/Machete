namespace Machete.Slices
{
    using System;


    /// <summary>
    /// A value, parsed from a slice and converted using a value factory. All parsing and conversion
    /// is lazy, performed when the value is accessed.
    /// </summary>
    /// <typeparam name="TValue"></typeparam>
    public class SinglePositionSliceValue<TValue> :
        Value<TValue>
    {
        readonly TextSlice _slice;
        readonly int _position;
        readonly ValueFactory<TValue> _valueFactory;

        Value<TValue> _value;
        bool _valueComputed;

        public SinglePositionSliceValue(TextSlice slice, int position, ValueFactory<TValue> valueFactory)
        {
            _slice = slice;
            _position = position;
            _valueFactory = valueFactory;
        }

        Type IValue.ValueType => typeof(TValue);
        bool IValue.IsPresent => _valueComputed ? _value.IsPresent : GetValue().IsPresent;
        bool IValue.HasValue => _valueComputed ? _value.HasValue : GetValue().HasValue;
        TValue Value<TValue>.Value => _valueComputed ? _value.Value : GetValue().Value;

        Value<TValue> GetValue()
        {
            if (_slice.TryGetSlice(_position, out var slice))
            {
                _value = _valueFactory(slice) ?? Value.Invalid<TValue>(slice);
            }
            else
            {
                _value = Value.Missing<TValue>();
            }

            _valueComputed = true;

            return _value;
        }

        public override string ToString()
        {
            return _valueComputed ? _value.ToString() : GetValue().ToString();
        }
    }
}