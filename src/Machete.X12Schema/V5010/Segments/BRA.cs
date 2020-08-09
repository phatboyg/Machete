namespace Machete.X12Schema.V5010
{
    using System;
    using X12;


    public interface BRA :
        X12Segment
    {
        Value<string> ReferenceIdentification { get; }
        
        Value<DateTime> Date { get; }
        
        Value<string> TransactionSetPurposeCode { get; }
        
        Value<string> ReceivingAdviceOrAcceptanceCertificationTypeCode { get; }
        
        Value<TimeSpan> Time { get; }
        
        Value<string> ReceivingConditionCode { get; }
        
        Value<string> ActionCode { get; }
    }
}