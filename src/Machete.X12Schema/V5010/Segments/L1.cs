namespace Machete.X12Schema.V5010
{
    using X12;


    public interface L1 :
        X12Segment
    {
        Value<int> LadingLineItemNumber { get; }
        
        Value<decimal> FreightRate { get; }
        
        Value<string> RateOrValueQualifier1 { get; }
        
        Value<decimal> AmountCharged { get; }
        
        Value<decimal> Advances { get; }
        
        Value<decimal> PrepaidAmount { get; }
        
        Value<string> RateCombinationPointCode { get; }
        
        Value<string> SpecialChargeOrAllowanceCode { get; }
        
        Value<string> RateClassCode { get; }
        
        Value<string> EntitlementCode { get; }
        
        Value<string> ChargeMethodOfPayment { get; }
        
        Value<string> SpecialChargeDescription { get; }
        
        Value<string> TariffApplicationCode { get; }
        
        Value<string> DeclaredValue { get; }
        
        Value<string> RateOrValueQualifier2 { get; }
        
        Value<string> LadingLiabilityCode { get; }
        
        Value<decimal> BilledOrRatedAsQuantity { get; }
        
        Value<string> BilledOrRatedAsQualifier { get; }
        
        Value<decimal> PercentageAsDecimal { get; }
        
        Value<string> CurrencyCode { get; }
        
        Value<decimal> Amount { get; }
        
        Value<decimal> LadingValue { get; }
    }
}