namespace Machete.X12Schema.V5010.Segments
{
    using X12;


    public interface PO4 :
        X12Segment
    {
        Value<int> Pack { get; }
        
        Value<decimal> Size { get; }
        
        Value<string> UnitOrBasisForMeasurementCode1 { get; }
        
        Value<string> PackagingCode { get; }
        
        Value<string> WeightQualifier { get; }
        
        Value<decimal> GrossWeightPerPack { get; }
        
        Value<string> UnitOrBasisForMeasurementCode2 { get; }
        
        Value<decimal> GrossVolumePerPack { get; }
        
        Value<string> UnitOrBasisForMeasurementCode3 { get; }
        
        Value<decimal> Length { get; }
        
        Value<decimal> Width { get; }
        
        Value<decimal> Height { get; }
        
        Value<string> UnitOrBasisForMeasurementCode4 { get; }
        
        Value<int> InnerPack { get; }
        
        Value<string> SurfaceLayerOrPositionCode { get; }
        
        Value<string> AssignedIdentification1 { get; }
        
        Value<string> AssignedIdentification2 { get; }
        
        Value<int> Number { get; }
    }
}