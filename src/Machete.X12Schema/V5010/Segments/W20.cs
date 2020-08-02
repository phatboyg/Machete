namespace Machete.X12Schema.V5010
{
    using X12;


    public interface W20 :
        X12Segment
    {
        Value<int> Pack { get; }
        
        Value<decimal> Size { get; }
        
        Value<string> UnitOrBasisOfMeasurementCode1 { get; }
        
        Value<decimal> Weight { get; }
        
        Value<string> WeightQualifier { get; }
        
        Value<string> WeightUnitCode { get; }
        
        Value<decimal> UnitWeight { get; }
        
        Value<decimal> Volume { get; }
        
        Value<string> UnitOrBasisOfMeasurementCode2 { get; }
        
        Value<string> Color { get; }
    }
}