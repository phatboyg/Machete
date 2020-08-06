namespace Machete.X12Schema.V5010
{
    using X12;


    public interface W19 :
        X12Segment
    {
        Value<string> QuantityOrStatusAdjustmentReasonCode { get; }
        
        Value<decimal> CreditOrDebitQuantity { get; }
        
        Value<string> UnitOrBasisOfMeasurementCode { get; }
        
        Value<string> UniversalProductCodeCaseCode { get; }
        
        Value<string> ProductOrServiceIdQualifier1 { get; }
        
        Value<string> ProductOrServiceIdQualifier2 { get; }
        
        Value<string> ProductOrServiceId2 { get; }
        
        Value<string> ProductOrServiceId1 { get; }
        
        Value<string> WarehouseLotNumber { get; }
        
        Value<decimal> Weight1 { get; }
        
        Value<string> WeightQualifier1 { get; }
        
        Value<string> WeightUnitCode1 { get; }
        
        Value<decimal> Weight2 { get; }
        
        Value<string> WeightQualifier2 { get; }
        
        Value<string> WeightUnitCode2 { get; }
        
        Value<string> InventoryTransactionTypeCode { get; }
        
        Value<string> ProductOrServiceIdQualifier3 { get; }
        
        Value<string> ProductOrServiceId3 { get; }
    }
}