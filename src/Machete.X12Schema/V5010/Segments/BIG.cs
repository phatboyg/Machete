namespace Machete.X12Schema.V5010
{
    using System;
    using X12;


    public interface BIG :
        X12Segment
    {
        Value<DateTime> Date1 { get; }
        
        Value<string> InvoiceNumber1 { get; }
        
        Value<DateTime> Date2 { get; }
        
        Value<string> PurchaseOrderNumber { get; }
        
        Value<string> ReleaseNumber { get; }
        
        Value<string> ChangeOrderSequenceNumber { get; }
        
        Value<string> TransactionTypeCode { get; }
        
        Value<string> TransactionSetPurposeCode { get; }
        
        Value<string> ActionCode { get; }
        
        Value<string> InvoiceNumber2 { get; }
        
        Value<string> HierarchicalStructureCode { get; }
    }
}