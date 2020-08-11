namespace Machete.X12Schema.V5010
{
    using System;
    using X12;


    public interface JIT :
        X12Segment
    {
        Value<decimal> Quantity { get; }
        
        Value<TimeSpan> Time { get; }
    }
}