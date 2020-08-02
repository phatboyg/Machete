namespace Machete.X12Schema.V5010
{
    using X12;


    public interface W13 :
        X12Segment
    {
        Value<int> Quantity { get; }
        
        Value<string> UnitOrBasisOfMeasurementCode { get; }
        
        Value<string> ReceivingConditionCode { get; }
        
        Value<string> WarehouseLotNumber { get; }
        
        Value<string> DamageReasonCode { get; }
    }
}