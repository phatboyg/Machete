namespace Machete.Values
{
    using System;


    public class ConvertedValue<TValue> :
        Value<TValue>
    {
        public ConvertedValue(TextSlice slice, TValue value, bool hasValue = true)
        {
            Value = value;
            HasValue = hasValue;

            Slice = slice;
        }

        bool IValue.IsPresent => true;
        public TextSlice Slice { get; }
        Type IValue.ValueType => typeof(TValue);
        public bool HasValue { get; }
        public TValue Value { get; }
    }
}