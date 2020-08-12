namespace Machete.X12Schema.V5010
{
    using X12;


    public interface L3 :
        X12Segment
    {
        Value<decimal> Weight { get; }
        
        Value<string> WeightQualifier { get; }
        
        Value<decimal> FreightRate { get; }
        
        Value<string> RateOrValueQualifier1 { get; }
        
        Value<decimal> AmountCharged { get; }
        
        Value<decimal> Advances { get; }
        
        Value<decimal> PrepaidAmount { get; }
        
        Value<string> SpecialChargeOrAllowanceCode { get; }
        
        Value<decimal> Volume { get; }
        
        Value<string> VolumeUnitQualifier { get; }
        
        Value<int> LadingQuantity { get; }
        
        Value<string> WeightUnitCode { get; }
        
        Value<string> TariffNumber { get; }
        
        Value<string> DeclaredValue { get; }
        
        Value<string> RateOrValueQualifier2 { get; }
    }
}