namespace Machete.X12Schema.V5010
{
    using System;
    using X12;


    public interface G62 :
        X12Segment
    {
        Value<string> DateQualifier { get; }
        
        Value<DateTime> Date { get; }
        
        Value<string> TimeQualifier { get; }
        
        Value<TimeSpan> Time { get; }
        
        Value<string> TimeCode { get; }
    }
}