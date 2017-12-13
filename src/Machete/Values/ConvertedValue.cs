namespace Machete.Values
{
    using System;


    public class ConvertedValue<TValue> :
        Value<TValue>
    {
        public ConvertedValue(TValue value, bool hasValue = true)
        {
            Value = value;
            HasValue = hasValue;
        }

        bool IValue.IsPresent => true;
        Type IValue.ValueType => typeof(TValue);
        public bool HasValue { get; }
        public TValue Value { get; }
    }
}