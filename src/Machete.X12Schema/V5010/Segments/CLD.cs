namespace Machete.X12Schema.V5010
{
    using X12;


    public interface CLD :
        X12Segment
    {
        Value<int> NumberOfLoads { get; }
        
        Value<decimal> NumberOfUnitsShipped { get; }
        
        Value<string> PackagingCode { get; }
        
        Value<decimal> Size { get; }
        
        Value<string> UnitOrBasisForMeasurementCode { get; }
    }
}