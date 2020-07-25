namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LH2 :
        X12Segment
    {
        Value<string> HazardousClassification { get; }
        
        Value<string> HazardousClassQualifier { get; }
        
        Value<string> HazardousPlacardNotation { get; }
        
        Value<string> HazardousEndorsement { get; }
        
        Value<string> ReportableQuantityCode { get; }
        
        Value<string> UnitOrBasisForMeasurementCode1 { get; }
        
        Value<decimal> Temperature1 { get; }
        
        Value<string> UnitOrBasisForMeasurementCode2 { get; }
        
        Value<decimal> Temperature2 { get; }
        
        Value<string> UnitOrBasisForMeasurementCode3 { get; }
        
        Value<decimal> Temperature3 { get; }
    }
}