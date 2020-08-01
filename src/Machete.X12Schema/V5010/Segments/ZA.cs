namespace Machete.X12Schema.V5010
{
    using System;
    using X12;


    public interface ZA :
        X12Segment
    {
        Value<string> ActivityCode { get; }
        
        Value<decimal> Quantity { get; }
        
        Value<string> UnitOrBasisForMeasurementCode { get; }
        
        Value<string> DateOrTimeQualifier { get; }
        
        Value<DateTime> Date { get; }

        Value<string> ReferenceIdentificationQualifier { get; }

        Value<string> ReferenceIdentification { get; }
        
        Value<string> YesNoConditionOrResponseCode { get; }
    }
}