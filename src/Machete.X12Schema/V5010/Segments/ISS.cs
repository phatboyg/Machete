namespace Machete.X12Schema.V5010
{
    using X12;


    public interface ISS :
        X12Segment
    {
        Value<decimal> NumberOfUnitsShipped { get; }
        
        Value<string> UnitOrBasisForMeasurementCode1 { get; }
        
        Value<decimal> Weight1 { get; }
        
        Value<string> UnitOrBasisForMeasurementCode2 { get; }
        
        Value<decimal> Volume { get; }
        
        Value<string> UnitOrBasisForMeasurementCode3 { get; }
        
        Value<decimal> Quantity { get; }
        
        Value<decimal> Weight2 { get; }
    }
}