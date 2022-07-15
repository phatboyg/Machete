namespace Machete.Values
{
    using System;


    public class StringValue :
        Value<string>
    {
        readonly TextSpan _sourceSpan;
        readonly ParseText _sourceText;
        string _text;

        bool _textComputed;

        public StringValue(ParseText sourceText, TextSpan sourceSpan, bool hasValue)
        {
            _sourceText = sourceText;
            _sourceSpan = sourceSpan;
            HasValue = hasValue;
        }

        public StringValue(ParseText sourceText, TextSpan sourceSpan)
        {
            _sourceText = sourceText;
            _sourceSpan = sourceSpan;
            HasValue = !sourceSpan.IsEmpty;
        }

        bool IValue.IsPresent => true;
        Type IValue.ValueType => typeof(string);
        public bool HasValue { get; }
        string Value<string>.Value => _textComputed ? _text : GetText();

        string GetText()
        {
            _text = _sourceText.ToString(_sourceSpan);
            _textComputed = true;

            return _text;
        }

        public override string ToString()
        {
            return _textComputed ? _text : GetText();
        }
    }


    public class StringSpanValue :
        Value<string>
    {
        public StringSpanValue(ReadOnlySpan<char> span, bool hasValue)
        {
            HasValue = hasValue;

            Value = span.ToString();
        }

        public StringSpanValue(ReadOnlySpan<char> span)
        {
            HasValue = !span.IsEmpty;

            Value = HasValue ? span.ToString() : string.Empty;
        }

        public bool IsPresent => true;
        public Type ValueType => typeof(string);

        public bool HasValue { get; }

        public string Value { get; }
    }
}