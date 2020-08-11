namespace Machete.X12Schema.V5010
{
    using X12;


    public interface IT3x :
        X12Segment
    {
        Value<decimal> NumberOfUnitsShipped { get; }
        
        Value<string> UnitOrBasisForMeasurementCode { get; }
        
        Value<string> ShipmentOrOrderStatusCode { get; }
        
        Value<decimal> QuantityDifference { get; }
        
        Value<string> ChangeReasonCode { get; }
    }
}