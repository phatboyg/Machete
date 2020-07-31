namespace Machete.X12Schema.V5010
{
    using System;
    using X12;


    public interface BSR :
        X12Segment
    {
        Value<string> StatusReportCode { get; }
        
        Value<string> OrderOrItemCode { get; }
        
        Value<string> ReferenceIdentification1 { get; }
        
        Value<DateTime> Date1 { get; }
        
        Value<string> ProductOrDateCode { get; }
        
        Value<string> LocationCode { get; }
        
        Value<TimeSpan> Time1 { get; }
        
        Value<string> ReferenceIdentification2 { get; }
        
        Value<DateTime> Date2 { get; }
        
        Value<TimeSpan> Time2 { get; }
        
        Value<string> TransactionSetPurposeCode { get; }
        
        Value<string> ActionCode { get; }
    }
}