namespace Machete.X12Schema.V5010
{
    using System;
    using X12;


    public interface BAK :
        X12Segment
    {
        Value<string> TransactionSetPurposeCode { get; }
        
        Value<string> AcknowledgementType { get; }
        
        Value<string> PurchaseOrderNumber { get; }
        
        Value<DateTime> Date1 { get; }
        
        Value<string> ReleaseNumber { get; }
        
        Value<string> RequestReferenceNumber { get; }
        
        Value<string> ContractNumber { get; }
        
        Value<string> ReferenceIdentification { get; }
        
        Value<DateTime> Date2 { get; }
        
        Value<string> TransactionTypeCode { get; }
    }
}