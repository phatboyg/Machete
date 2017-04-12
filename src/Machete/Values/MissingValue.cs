namespace Machete.Values
{
    using System;


    /// <summary>
    /// A not-present value, one that is not present in the source and does
    /// not have a value.
    /// </summary>
    /// <typeparam name="TValue">The value type</typeparam>
    public class MissingValue<TValue> :
        Value<TValue>
    {
        Type IValue.ValueType => typeof(TValue);
        bool IValue.IsPresent => false;
        TextSlice IValue.Slice => Slice.Empty;
        bool IValue.HasValue => false;

        TValue Value<TValue>.Value
        {
            get { throw new ValueMissingException("The value is missing."); }
        }
    }
}