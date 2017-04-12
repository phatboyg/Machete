namespace Machete.Values
{
    using System;


    public class EmptyValue<TValue> :
        Value<TValue>
    {
        Type IValue.ValueType => typeof(TValue);
        bool IValue.IsPresent => true;
        TextSlice IValue.Slice => Slice.Empty;
        bool IValue.HasValue => false;

        TValue Value<TValue>.Value
        {
            get { throw new ValueEmptyException("The value is empty."); }
        }
    }
}