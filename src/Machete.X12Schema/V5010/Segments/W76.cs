namespace Machete.X12Schema.V5010
{
    using X12;


    public interface W76 :
        X12Segment
    {
        Value<int> Quantity { get; }
        
        Value<decimal> Weight { get; }
        
        Value<string> UnitOrBasisOfMeasurementCode1 { get; }
        
        Value<decimal> Volume { get; }
        
        Value<string> UnitOrBasisOfMeasurementCode2 { get; }
        
        Value<decimal> OrderSizingFactor { get; }
    }
}