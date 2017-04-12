namespace Machete.Values
{
    using System;


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
        TextSlice IValue.Slice => _slice;

        TValue Value<TValue>.Value
        {
            get { throw new ValueFormatException($"The value {_slice.Text} could not be converted to {typeof(TValue).Name}"); }
        }
    }
}