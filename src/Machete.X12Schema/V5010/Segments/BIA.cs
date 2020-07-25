namespace Machete.X12Schema.V5010
{
    using System;
    using X12;


    public interface BIA :
        X12Segment
    {
        Value<string> TransactionSetPurposeCode { get; }
        
        Value<string> ReportTypeCode { get; }
        
        Value<string> ReferenceIdentification { get; }
        
        Value<DateTime> Date { get; }
        
        Value<TimeSpan> Time { get; }
        
        Value<string> ActionCode { get; }
    }
}