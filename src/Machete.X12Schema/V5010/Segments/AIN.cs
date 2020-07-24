namespace Machete.X12Schema.V5010
{
    using X12;


    public interface AIN :
        X12Segment
    {
        Value<string> TypeOfIncomeCode { get; }
        
        Value<string> FrequencyCode { get; }
        
        Value<decimal> MonetaryAmount { get; }
        
        Value<decimal> Quantity1 { get; }
        
        Value<string> YesNoConditionOrResponseCode { get; }
        
        Value<string> ReferenceIdentification { get; }
        
        Value<string> AmountQualifierCode { get; }
        
        Value<string> TaxTreatmentCode { get; }
        
        Value<decimal> EarningsRateOfPay { get; }

        Value<string> UnitOrBasisOfMeasurement { get; }
        
        Value<decimal> Quantity2 { get; }

        Value<string> IndustryCode { get; }
    }
}