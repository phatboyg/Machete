namespace Machete.X12Schema.V5010
{
    using System;
    using X12;


    public interface BCH :
        X12Segment
    {
        Value<string> TransactionSetPurposeCode { get; }
        
        Value<string> PurchaseOrderTypeCode { get; }
        
        Value<string> PurchaseOrderNumber { get; }
        
        Value<string> ReleaseNumber { get; }
        
        Value<string> ChangeOrderSequenceNumber { get; }
        
        Value<DateTime> Date1 { get; }
        
        Value<string> RequestReferenceNumber { get; }
        
        Value<string> ContractNumber { get; }
        
        Value<string> ReferenceIdentification { get; }
        
        Value<DateTime> Date2 { get; }
        
        Value<DateTime> Date3 { get; }
        
        Value<string> ContractTypeCode { get; }
        
        Value<string> SecurityLevelCode { get; }
        
        Value<string> AcknowledgementType { get; }
        
        Value<string> TransactionTypeCode { get; }
        
        Value<string> PurchaseCategory { get; }
    }
}