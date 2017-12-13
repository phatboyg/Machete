namespace Machete.Values
{
    using System;


    public class ConvertValue<TValue> :
        Value<TValue>
    {
        readonly TextSlice _slice;
        readonly int? _position;
        readonly IValueConverter<TValue> _converter;

        Value<TValue> _value;
        bool _valueComputed;

        public ConvertValue(TextSlice slice, int position, IValueConverter<TValue> converter)
        {
            _slice = slice;
            _position = position;
            _converter = converter;
        }

        public ConvertValue(TextSlice slice, IValueConverter<TValue> converter)
        {
            _slice = slice;
            _converter = converter;
        }

        Type IValue.ValueType => typeof(TValue);
        bool IValue.IsPresent => _valueComputed ? _value.IsPresent : GetValue().IsPresent;
        bool IValue.HasValue => _valueComputed ? _value.HasValue : GetValue().HasValue;
        TValue Value<TValue>.Value => _valueComputed ? _value.Value : GetValue().Value;

        Value<TValue> GetValue()
        {
            if (_position.HasValue)
            {
                if (_slice.TryGetSlice(_position.Value, out var slice))
                {
                    _value = _converter.TryConvert(slice, out var getValue) ? getValue : Value.Invalid<TValue>(slice);
                }
                else
                {
                    _value = Value.Missing<TValue>();
                }
            }
            else
            {
                _value = _converter.TryConvert(_slice, out var getValue) ? getValue : Value.Invalid<TValue>(_slice);
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