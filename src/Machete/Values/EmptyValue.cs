namespace Machete.Values
{
    using System;


    public class EmptyValue<TValue> :
        Value<TValue>
    {
        Type IValue.ValueType => typeof(TValue);
        bool IValue.IsPresent => true;
        bool IValue.HasValue => false;

        TValue Value<TValue>.Value => throw new ValueEmptyException("The value is empty.");
    }
}