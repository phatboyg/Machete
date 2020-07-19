namespace Machete.X12Schema.V5010.Segments
{
    using System;
    using X12;


    public interface SR :
        X12Segment
    {
        Value<string> AssignedIdentification { get; }
        
        Value<string> DayRotation { get; }
        
        Value<TimeSpan> Time1 { get; }
        
        Value<TimeSpan> Time2 { get; }
        
        Value<string> FreeFormMessage { get; }
        
        Value<decimal> UnitPrice { get; }
        
        Value<decimal> Quantity { get; }
        
        Value<DateTime> Date1 { get; }
        
        Value<DateTime> Date2 { get; }
        
        Value<string> ProductOrServiceId1 { get; }
        
        Value<string> ProductOrServiceId2 { get; }
    }
}