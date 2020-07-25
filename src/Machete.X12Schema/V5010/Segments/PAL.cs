namespace Machete.X12Schema.V5010
{
    using X12;


    public interface PAL :
        X12Segment
    {
        Value<string> PalletTypeCode { get; }
        
        Value<int> PalletTiers { get; }
        
        Value<int> PalletBlocks { get; }
        
        Value<int> Pack { get; }
        
        Value<decimal> UnitWeight { get; }
        
        Value<string> UnitOrBasisForMeasurementCode1 { get; }
        
        Value<decimal> Length { get; }
        
        Value<decimal> Width { get; }
        
        Value<decimal> Height { get; }
        
        Value<string> UnitOrBasisForMeasurementCode2 { get; }
        
        Value<decimal> GrossWeightPerPack1 { get; }
        
        Value<string> UnitOrBasisForMeasurementCode3 { get; }
        
        Value<decimal> GrossWeightPerPack2 { get; }
        
        Value<string> UnitOrBasisForMeasurementCode4 { get; }
        
        Value<decimal> PalletExchangeCode { get; }
        
        Value<int> InnerPack { get; }
    }
}