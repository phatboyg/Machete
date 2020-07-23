namespace Machete.X12Schema.V5010.Segments
{
    using System;
    using X12;


    public interface BCD :
        X12Segment
    {
        Value<DateTime> Date1 { get; }
        
        Value<string> CreditOrDebitAdjustmentNumber { get; }
        
        Value<string> TransactionHandlingCode { get; }
        
        Value<decimal> Amount { get; }
        
        Value<string> CreditOrDebitFlagCode { get; }
        
        Value<DateTime> Date2 { get; }
        
        Value<string> InvoiceNumber { get; }
        
        Value<string> VendorOrderNumber { get; }
        
        Value<DateTime> Date3 { get; }
        
        Value<string> PurchaseOrderNumber { get; }
        
        Value<string> TransactionSetPurposeCode { get; }
        
        Value<string> TransactionTypeCode { get; }
        
        Value<string> ReferenceIdentificationQualifier { get; }

        Value<string> ReferenceIdentification { get; }

        Value<string> ActionCode { get; }
    }
}