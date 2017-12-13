namespace Machete.Values
{
    using System;


    public class AdjustedValue<TOriginal, TValue> :
        Value<TValue>
    {
        readonly Value<TOriginal> _originalValue;

        public AdjustedValue(Value<TOriginal> originalValue, TValue value, bool hasValue = true)
        {
            _originalValue = originalValue;
            Value = value;
            HasValue = hasValue;
        }

        bool IValue.IsPresent => true;
        Type IValue.ValueType => typeof(TValue);
        public bool HasValue { get; }
        public TValue Value { get; }

        public override string ToString()
        {
            return _originalValue.ToString();
        }
    }
}