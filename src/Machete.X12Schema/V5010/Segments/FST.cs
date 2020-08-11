namespace Machete.X12Schema.V5010
{
    using System;
    using X12;


    public interface FST :
        X12Segment
    {
        Value<decimal> Quantity { get; }
        
        Value<string> ForecastQualifier { get; }
        
        Value<string> TimingQualifier { get; }

        Value<DateTime> Date1 { get; }
        
        Value<DateTime> Date2 { get; }
        
        Value<string> DateOrTimeQualifier { get; }
        
        Value<TimeSpan> Time { get; }
        
        Value<string> ReferenceIdentificationQualifier { get; }

        Value<string> ReferenceIdentification { get; }
        
        Value<string> PlanningScheduleTypeCode { get; }
        
        Value<string> QuantityQualifier { get; }

        Value<string> AdjustmentReasonCode { get; }

        Value<string> Description { get; }
    }
}