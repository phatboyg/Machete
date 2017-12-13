namespace Machete.Values
{
    using System;


    public class ConvertedValue<TValue> :
        Value<TValue>
    {
        readonly ParseText _text;
        readonly TextSpan _span;

        public ConvertedValue(ParseText text, TextSpan span, TValue value, bool hasValue = true)
        {
            _text = text;
            _span = span;
            Value = value;
            HasValue = hasValue;
        }

        bool IValue.IsPresent => true;
        Type IValue.ValueType => typeof(TValue);
        public bool HasValue { get; }
        public TValue Value { get; }

        public override string ToString()
        {
            return _text.ToString(_span);
        }
    }
}