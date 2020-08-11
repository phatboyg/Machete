namespace Machete.X12Schema.V5010
{
    using System;
    using X12;


    public interface SHP :
        X12Segment
    {
        Value<string> QuantityQualifier { get; }

        Value<decimal> Quantity { get; }
        
        Value<string> DateOrTimeQualifier { get; }
        
        Value<DateTime> Date1 { get; }
        
        Value<TimeSpan> Time1 { get; }
        
        Value<DateTime> Date2 { get; }
        
        Value<TimeSpan> Time2 { get; }
    }
}