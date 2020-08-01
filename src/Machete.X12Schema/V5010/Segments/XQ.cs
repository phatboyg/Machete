namespace Machete.X12Schema.V5010
{
    using System;
    using X12;


    public interface XQ :
        X12Segment
    {
        Value<string> TransactionHandlingCode { get; }
        
        Value<DateTime> Date1 { get; }
        
        Value<DateTime> Date2 { get; }
        
        Value<string> ReferenceIdentification { get; }
        
        Value<string> TransactionSetPurposeCode { get; }
    }
}