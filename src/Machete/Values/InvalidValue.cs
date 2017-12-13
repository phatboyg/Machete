namespace Machete.Values
{
    using System;
    using Internals.Extensions;


    public class InvalidValue<TValue> :
        Value<TValue>
    {
        readonly ParseText _sourceText;
        readonly TextSpan _sourceSpan;

        public InvalidValue(ParseText sourceText, TextSpan sourceSpan)
        {
            _sourceText = sourceText;
            _sourceSpan = sourceSpan;
        }

        Type IValue.ValueType => typeof(TValue);
        bool IValue.HasValue => false;
        bool IValue.IsPresent => true;

        TValue Value<TValue>.Value => throw new ValueFormatException($"The value {_sourceText.ToString(_sourceSpan)} could not be converted to {TypeCache<TValue>.ShortName}");

        public override string ToString()
        {
            return _sourceText.ToString(_sourceSpan);
        }
    }
}