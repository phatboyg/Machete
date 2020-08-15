namespace Machete.X12Schema.V5010
{
    using X12;


    public interface SLI :
        X12Segment
    {
        Value<string> LoanTypeCode { get; }
        
        Value<decimal> Amount1 { get; }
        
        Value<decimal> Amount2 { get; }
        
        Value<decimal> InterestRate { get; }
        
        Value<string> LoanRateTypeCode { get; }
        
        Value<string> DateTimePeriodFormatQualifier1 { get; }
        
        Value<string> DateTimePeriod1 { get; }
        
        Value<string> ReferenceIdentification { get; }
        
        Value<string> YesNoConditionOrResponseCode1 { get; }
        
        Value<string> DateTimePeriodFormatQualifier2 { get; }
        
        Value<string> DateTimePeriod2 { get; }
        
        Value<string> DateTimePeriodFormatQualifier3 { get; }
        
        Value<string> DateTimePeriod3 { get; }
        
        Value<decimal> Amount3 { get; }
        
        Value<decimal> Quantity1 { get; }
        
        Value<decimal> Quantity2 { get; }
        
        Value<decimal> Quantity3 { get; }
        
        Value<string> YesNoConditionOrResponseCode2 { get; }
        
        Value<string> YesNoConditionOrResponseCode3 { get; }
        
        Value<string> DateTimePeriodFormatQualifier4 { get; }
        
        Value<string> DateTimePeriod4 { get; }
        
        Value<string> PaymentMethodTypeCode { get; }
    }
}