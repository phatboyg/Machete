namespace Machete.X12Schema.V5010
{
    using X12;


    public interface W18 :
        X12Segment
    {
        Value<string> TemperatureProbeLocationCode { get; }
        
        Value<string> Temperature { get; }
        
        Value<string> UnitOrBasisOfMeasurementCode { get; }
    }
}