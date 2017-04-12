namespace Machete.Values
{
    using System;


    public class EmptyValueArray<TValue> :
        ValueArray<TValue>
    {
        Type IValue.ValueType => typeof(TValue);
        bool IValue.HasValue => false;
        bool IValue.IsPresent => true;
        TextSlice IValue.Slice => Slice.Empty;

        public Value<TValue> this[int index]
        {
            get { throw new ValueEmptyException("The value array is empty."); }
        }

        bool ValueArray<TValue>.TryGetValue(int index, out Value<TValue> value)
        {
            throw new ValueEmptyException("The value array is empty.");
        }
    }
}