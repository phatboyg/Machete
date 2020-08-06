namespace Machete.X12Schema.V5010
{
    using System;
    using X12;


    public interface W15 :
        X12Segment
    {
        Value<DateTime> Date { get; }
        
        Value<string> AdjustmentNumber1 { get; }
        
        Value<string> AdjustmentNumber2 { get; }
        
        Value<string> TransactionSetPurposeCode { get; }
        
        Value<string> TransactionTypeCode { get; }
        
        Value<string> ActionCode { get; }
    }
}