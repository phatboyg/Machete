namespace Machete.X12Schema.V5010
{
    using System;
    using X12;


    public interface SCH :
        X12Segment
    {
        Value<decimal> Quantity { get; }
        
        Value<string> UnitOrBasisForMeasurementCode { get; }
        
        Value<string> EntityIdentifierCode { get; }
        
        Value<string> Name { get; }
        
        Value<string> DateOrTimeQualifier1 { get; }
        
        Value<DateTime> Date1 { get; }
        
        Value<TimeSpan> Time1 { get; }
        
        Value<string> DateOrTimeQualifier2 { get; }
        
        Value<DateTime> Date2 { get; }
        
        Value<TimeSpan> Time2 { get; }
        
        Value<string> RequestReferenceNumber { get; }
        
        Value<string> AssignedIdentification { get; }
    }
}