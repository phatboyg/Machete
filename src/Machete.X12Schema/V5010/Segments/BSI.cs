namespace Machete.X12Schema.V5010
{
    using System;
    using X12;


    public interface BSI :
        X12Segment
    {
        Value<string> ReferenceIdentification { get; }
        
        Value<DateTime> Date { get; }
        
        Value<string> OrderOrItemCode { get; }
        
        Value<string> ProductOrDateCode { get; }
        
        Value<string> LocationCode { get; }
        
        Value<TimeSpan> Time { get; }
        
        Value<string> TransactionSetPurposeCode { get; }
        
        Value<string> TransactionTypeCode { get; }
        
        Value<string> ActionCode { get; }
    }
}