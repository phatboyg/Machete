namespace Machete.X12Schema.V5010
{
    using X12;


    public interface CTT :
        X12Segment
    {
        Value<int> NumberOfLineItems { get; }
        
        Value<decimal> HashTotal { get; }
        
        Value<decimal> Weight { get; }
        
        Value<string> UnitOrBasisForMeasurementCode1 { get; }
        
        Value<decimal> Volume { get; }
        
        Value<string> UnitOrBasisForMeasurementCode2 { get; }
        
        Value<decimal> Description { get; }
    }
}