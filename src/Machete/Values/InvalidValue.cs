namespace Machete.Values
{
    using System;
    using Internals.Extensions;


    public class InvalidValue<TValue> :
        Value<TValue>
    {
        readonly TextSlice _slice;

        public InvalidValue(TextSlice slice)
        {
            _slice = slice;
        }

        Type IValue.ValueType => typeof(TValue);
        bool IValue.HasValue => false;
        bool IValue.IsPresent => true;

        TValue Value<TValue>.Value => throw new ValueFormatException($"The value {_slice.Text} could not be converted to {TypeCache<TValue>.ShortName}");

        public override string ToString()
        {
            return _slice.SourceText.ToString(_slice.SourceSpan);
        }
    }
}