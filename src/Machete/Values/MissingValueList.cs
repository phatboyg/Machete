namespace Machete.Values
{
    using System;


    /// <summary>
    /// A missing value array is used when the source fragment is missing.
    /// </summary>
    /// <typeparam name="TValue">The value type</typeparam>
    public class MissingValueList<TValue> :
        ValueList<TValue>
    {
        Type IValue.ValueType => typeof(TValue);
        bool IValue.HasValue => false;
        bool IValue.IsPresent => false;

        public Value<TValue> this[int index] => Value.Missing<TValue>();

        bool ValueList<TValue>.TryGetValue(int index, out Value<TValue> value)
        {
            value = Value.Missing<TValue>();
            return false;
        }

        public override string ToString()
        {
            return string.Empty;
        }
    }
}