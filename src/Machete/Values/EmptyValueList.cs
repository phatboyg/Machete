namespace Machete.Values
{
    using System;


    public class EmptyValueList<TValue> :
        ValueList<TValue>
    {
        Type IValue.ValueType => typeof(TValue);
        bool IValue.HasValue => false;
        bool IValue.IsPresent => true;

        public Value<TValue> this[int index] => throw new ValueEmptyException("The value list is empty.");

        bool ValueList<TValue>.TryGetValue(int index, out Value<TValue> value)
        {
            throw new ValueEmptyException("The value list is empty.");
        }

        public override string ToString()
        {
            return string.Empty;
        }
    }
}