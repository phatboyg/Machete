namespace Machete.Values
{
    using System;


    public class ConvertedValue<TValue> :
        Value<TValue>
    {
        readonly TextSpan _span;
        readonly ParseText _text;

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


    public class SpanValue<TValue> :
        Value<TValue>
    {
        public SpanValue(TValue value, bool hasValue = true)
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