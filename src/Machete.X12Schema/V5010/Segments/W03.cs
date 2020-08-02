namespace Machete.X12Schema.V5010
{
    using X12;


    public interface W03 :
        X12Segment
    {
        Value<decimal> NumberOfUnitsShipped { get; }
        
        Value<decimal> Weight { get; }
        
        Value<string> UnitOrBasisOfMeasurementCode1 { get; }
        
        Value<decimal> Volume { get; }
        
        Value<string> UnitOrBasisOfMeasurementCode2 { get; }
        
        Value<int> LadingQuantity { get; }
        
        Value<string> UnitOrBasisOfMeasurementCode3 { get; }
    }
}