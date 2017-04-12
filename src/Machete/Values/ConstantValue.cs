namespace Machete.Values
{
    using System;
    using Slices;
    using Texts;


    public class ConstantValue<TValue> :
        Value<TValue>
    {
        TextSlice _slice;
        bool _fragmentComputed;

        public ConstantValue(TValue value, bool hasValue = true)
        {
            Value = value;
            HasValue = hasValue;
        }

        bool IValue.IsPresent => true;

        public TextSlice Slice
        {
            get
            {
                if (_fragmentComputed)
                    return _slice;

                _slice = GetSlice();
                _fragmentComputed = true;

                return _slice;
            }
        }

        Type IValue.ValueType => typeof(TValue);
        public bool HasValue { get; }
        public TValue Value { get; }

        public bool TryGetValue<T>(out Value<T> value)
        {
            value = this as Value<T>;

            return value != null;
        }

        public bool TryGetValue<T>(IValueConverter<T> valueConverter, out Value<T> value)
        {
            return valueConverter.TryConvert(Slice, out value);
        }

        TextSlice GetSlice()
        {
            return new StringSlice(HasValue ? new StringText(Value.ToString()) : ParseText.Empty);
        }
    }
}