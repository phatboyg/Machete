namespace Machete.Values
{
    using System;


    public class ConvertValue<TValue> :
        Value<TValue>
    {
        readonly TextSlice _slice;
        readonly int? _position;
        readonly IValueConverter<TValue> _converter;

        TextSlice _valueSlice;
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

        TextSlice IValue.Slice
        {
            get
            {
                if (_valueComputed)
                    return _valueSlice;

                GetValue();

                return _slice;
            }
        }

        TValue Value<TValue>.Value => _valueComputed ? _value.Value : GetValue().Value;

        Value<TValue> GetValue()
        {
            Value<TValue> value;

            TextSlice slice;
            if (_position.HasValue)
            {
                if (_slice.TryGetSlice(_position.Value, out slice))
                {
                    value = _converter.TryConvert(slice, out var getValue) ? getValue : new InvalidValue<TValue>(slice);
                }
                else
                {
                    slice = Slice.Missing;
                    value = Value.Missing<TValue>();
                }
            }
            else
            {
                slice = _slice;

                value = _converter.TryConvert(slice, out var getValue) ? getValue : new InvalidValue<TValue>(slice);
            }

            _valueSlice = slice ?? Slice.Missing;
            _value = value ?? Value.Missing<TValue>();

            _valueComputed = true;

            return _value;
        }
    }
}