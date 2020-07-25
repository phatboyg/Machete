namespace Machete.X12Schema.V5010
{
    using X12;


    public interface TD1 :
        X12Segment
    {
        Value<string> PackagingCode { get; }
        
        Value<int> LadingQuantity { get; }
        
        Value<string> CommodityCodeQualifier { get; }
        
        Value<string> CommodityCode { get; }
        
        Value<string> Description { get; }
        
        Value<string> WeightQualifier { get; }
        
        Value<decimal> Weight { get; }
        
        Value<string> UnitOrBasisForMeasurementCode1 { get; }
        
        Value<decimal> Volume { get; }
        
        Value<string> UnitOrBasisForMeasurementCode2 { get; }
    }
}