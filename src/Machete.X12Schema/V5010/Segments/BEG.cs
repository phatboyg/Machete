namespace Machete.X12Schema.V5010
{
    using System;
    using X12;


    public interface BEG :
        X12Segment
    {
        Value<string> TransactionSetPurposeCode { get; }
        
        Value<string> PurchaseOrderTypeCode { get; }
        
        Value<string> PurchaseOrderNumber { get; }
        
        Value<string> ReleaseNumber { get; }
        
        Value<DateTime> Date { get; }
        
        Value<string> ContractNumber { get; }
        
        Value<string> AcknowledgementType { get; }
        
        Value<string> InvoiceTypeCode { get; }
        
        Value<string> ContractTypeCode { get; }
        
        Value<string> PurchaseCategory { get; }
        
        Value<string> SecurityLevelCode { get; }
        
        Value<string> TransactionTypeCode { get; }
    }
}