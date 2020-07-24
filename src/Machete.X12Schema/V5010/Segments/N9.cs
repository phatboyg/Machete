namespace Machete.X12Schema.V5010
{
    using System;
    using X12;


    public interface N9 :
        X12Segment
    {
        Value<string> ReferenceIdentificationQualifier { get; }
        
        Value<string> ReferenceIdentification { get; }
        
        Value<string> Description { get; }
        
        Value<DateTime> Date { get; }
        
        Value<TimeSpan> Time { get; }
        
        Value<C040> ReferenceIdentifier { get; }
    }
}