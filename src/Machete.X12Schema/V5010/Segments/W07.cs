namespace Machete.X12Schema.V5010
{
    using X12;


    public interface W07 :
        X12Segment
    {
        Value<decimal> QuantityReceived { get; }
        
        Value<string> UnitOrBasisOfMeasurementCode { get; }
        
        Value<string> UniversalProductCodeCaseCode { get; }
        
        Value<string> ProductOrServiceIdQualifier1 { get; }
        
        Value<string> ProductOrServiceId1 { get; }
        
        Value<string> ProductOrServiceIdQualifier2 { get; }
        
        Value<string> ProductOrServiceId2 { get; }
        
        Value<string> WarehouseLotNumber { get; }
        
        Value<string> WarehouseDetailAdjustmentIdentifier { get; }
        
        Value<string> ProductOrServiceIdQualifier3 { get; }
        
        Value<string> ProductOrServiceId3 { get; }
    }
}