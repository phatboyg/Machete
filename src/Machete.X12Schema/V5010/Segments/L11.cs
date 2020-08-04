namespace Machete.X12Schema.V5010
{
    using System;
    using X12;


    public interface L11 :
        X12Segment
    {
        Value<string> ReferenceIdentification { get; }

        Value<string> ReferenceIdentificationQualifier { get; }

        Value<string> Description { get; }
        
        Value<DateTime> Date { get; }
        
        Value<string> YesNoConditionOrResponseCode { get; }
    }
}