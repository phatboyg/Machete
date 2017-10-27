namespace Machete.Values
{
    using System;
    using Slices;
    using Texts;


    public class ConstantValue<TValue> :
        Value<TValue>
    {
        TextSlice _slice;
        bool _sliceComputed;

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
                if (_sliceComputed)
                    return _slice;

                _slice = GetSlice();
                _sliceComputed = true;

                return _slice;
            }
        }

        Type IValue.ValueType => typeof(TValue);
        public bool HasValue { get; }
        public TValue Value { get; }

        TextSlice GetSlice()
        {
            return new StringTextSlice(HasValue ? new StringText(Value.ToString()) : ParseText.Empty);
        }
    }
}