namespace Machete.X12Schema.V5010
{
    using System;
    using X12;


    public interface ITD :
        X12Segment
    {
        Value<string> TermsTypeCode { get; }
        
        Value<string> TermsBasisDateCode { get; }
        
        Value<decimal> TermsDiscountPercentage { get; }
        
        Value<DateTime> TermsDiscountDueDate { get; }
        
        Value<int> TermsDiscountDaysDue { get; }
        
        Value<DateTime> TermsNetDueDate { get; }
        
        Value<int> TermsNetDays { get; }
        
        Value<decimal> TermsDiscountAmount { get; }
        
        Value<DateTime> TermsDeferredDueDate { get; }
        
        Value<decimal> DeferredAmountDue { get; }
        
        Value<decimal> PercentageOfInvoicePayable { get; }
        
        Value<string> Description { get; }
        
        Value<int> DayOfMonth { get; }
        
        Value<string> PaymentMethodTypeCode { get; }
        
        Value<decimal> PercentageAsDecimal { get; }
    }
}