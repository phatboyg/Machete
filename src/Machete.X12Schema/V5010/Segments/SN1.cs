namespace Machete.X12Schema.V5010
{
    using X12;


    public interface SN1 :
        X12Segment
    {
        Value<string> AssignedIdentification { get; }
        
        Value<decimal> NumberOfUnitsShipped { get; }
        
        Value<string> UnitOrBasisForMeasurementCode1 { get; }
        
        Value<decimal> QuantityShippedToDate { get; }
        
        Value<decimal> QuantityOrdered { get; }
        
        Value<string> UnitOrBasisForMeasurementCode2 { get; }
        
        Value<string> ReturnableContainerLoadMakeUpCode { get; }
        
        Value<string> LineItemStatusCode { get; }
    }
}