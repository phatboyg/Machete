namespace Machete.X12Schema.V5010
{
    using System;
    using X12;


    public interface LHR :
        X12Segment
    {
        Value<string> ReferenceIdentificationQualifier { get; }
        
        Value<string> ReferenceIdentification { get; }
        
        Value<DateTime> Date { get; }
    }
}