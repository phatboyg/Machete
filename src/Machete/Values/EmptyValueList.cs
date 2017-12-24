namespace Machete.Values
{
    using System;


    /// <summary>
    /// A missing value array is used when the source fragment is empty.
    /// </summary>
    /// <typeparam name="TValue">The value type</typeparam>
    public class EmptyValueList<TValue> :
        ValueList<TValue>
    {
        Type IValue.ValueType => typeof(TValue);
        bool IValue.HasValue => false;
        bool IValue.IsPresent => true;

        public Value<TValue> this[int index] => Value.Empty<TValue>();

        bool ValueList<TValue>.TryGetValue(int index, out Value<TValue> value)
        {
            value = Value.Empty<TValue>();
            return false;
        }

        public override string ToString()
        {
            return string.Empty;
        }
    }
}