namespace Machete.X12Schema.V5010
{
    using X12;


    public interface W04 :
        X12Segment
    {
        Value<decimal> NumberOfUnitsShipped { get; }
        
        Value<string> UnitOrBasisOfMeasurementCode { get; }
        
        Value<string> UniversalProductCodeCaseCode { get; }
        
        Value<string> ProductOrServiceIdQualifier1 { get; }
        
        Value<string> ProductOrServiceId1 { get; }
        
        Value<string> ProductOrServiceIdQualifier2 { get; }
        
        Value<string> ProductOrServiceId2 { get; }
        
        Value<string> FreightClassCode { get; }
        
        Value<string> RateClassCode { get; }
        
        Value<string> CommodityCodeQualifier { get; }
        
        Value<string> CommodityCode { get; }
        
        Value<string> PalletBlockAndTiers { get; }
        
        Value<string> InboundConditionHoldCode { get; }
        
        Value<string> ProductOrServiceIdQualifier3 { get; }
        
        Value<string> ProductOrServiceId3 { get; }
    }
}