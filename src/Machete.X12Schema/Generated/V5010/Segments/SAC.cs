namespace Machete.X12Schema.V5010.Segments
{
    using X12;


    public interface SAC :
        X12Segment
    {
        Value<string> AllowanceOrChargeIndicator { get; }
        
        Value<string> ServicePromotionAllowanceOrChargeCode { get; }
        
        Value<string> AgencyQualifierCode { get; }
        
        Value<string> AgencyServicePromotionAllowanceOrChargeCode { get; }
        
        Value<decimal> Amount { get; }
        
        Value<string> AllowanceOrChargePercentQualifier { get; }
        
        Value<decimal> PercentDecimalFormat { get; }
        
        Value<decimal> Rate { get; }
        
        Value<string> UnitOrBasisForMeasurementCode { get; }
        
        Value<decimal> Quantity1 { get; }
        
        Value<decimal> Quantity2 { get; }
        
        Value<string> AllowanceOrChargeMethodOfHandlingCode { get; }
        
        Value<string> ReferenceIdentification { get; }
        
        Value<string> OptionNumber { get; }
        
        Value<string> Description { get; }
        
        Value<string> LanguageCode { get; }
    }
}