namespace Machete.Values
{
    using System;


    public class StringValue :
        Value<string>
    {
        readonly ParseText _sourceText;
        readonly TextSpan _sourceSpan;

        bool _textComputed;
        string _text;

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
}