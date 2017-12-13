namespace Machete.Values
{
    using System;


    public class ConstantValue<TValue> :
        Value<TValue>
    {
        public ConstantValue(TValue value, bool hasValue = true)
        {
            Value = value;
            HasValue = hasValue;
        }

        bool IValue.IsPresent => true;
        Type IValue.ValueType => typeof(TValue);
        public bool HasValue { get; }
        public TValue Value { get; }

        public override string ToString()
        {
            return HasValue ? Value.ToString() : string.Empty;
        }
    }
}