namespace Machete.X12Schema.V5010
{
    using System;
    using X12;


    public interface LDT :
        X12Segment
    {
        Value<string> LeadTimeCode { get; }
        
        Value<decimal> Quantity { get; }
        
        Value<string> UnitOfTimePeriodOrInterval { get; }

        Value<DateTime> Date { get; }
    }
}