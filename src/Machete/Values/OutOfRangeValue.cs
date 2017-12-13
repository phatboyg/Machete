namespace Machete.Values
{
    using System;


    /// <summary>
    /// A not-present value, one that is not present in the source and does
    /// not have a value.
    /// </summary>
    /// <typeparam name="TValue">The value type</typeparam>
    public class OutOfRangeValue<TValue> :
        Value<TValue>
    {
        readonly int _index;
        readonly int _count;

        public OutOfRangeValue(int index, int count)
        {
            _index = index;
            _count = count;
        }

        Type IValue.ValueType => typeof(TValue);
        bool IValue.IsPresent => false;
        bool IValue.HasValue => false;

        TValue Value<TValue>.Value => throw new ValueOutOfRangeException($"The index is out of range (index: {_index}, count: {_count})");
    }
}