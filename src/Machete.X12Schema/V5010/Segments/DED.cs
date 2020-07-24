namespace Machete.X12Schema.V5010
{
    using System;
    using X12;


    public interface DED :
        X12Segment
    {
        Value<string> TypeOfDeduction { get; }
        
        Value<string> ReferenceIdentification1 { get; }

        Value<DateTime> Date { get; }

        Value<decimal> Amount { get; }
        
        Value<string> ReferenceIdentification2 { get; }
        
        Value<string> YesNoConditionOrResponseCode2 { get; }
        
        Value<string> Name { get; }
        
        Value<string> ReferenceIdentification3 { get; }
        
        Value<string> YesNoConditionOrResponseCode3 { get; }
    }
}