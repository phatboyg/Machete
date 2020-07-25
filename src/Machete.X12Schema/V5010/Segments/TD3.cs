namespace Machete.X12Schema.V5010
{
    using X12;


    public interface TD3 :
        X12Segment
    {
        Value<string> EquipmentDescriptionCode { get; }
        
        Value<string> EquipmentInitial { get; }
        
        Value<string> EquipmentNumber { get; }
        
        Value<string> WeightQualifier { get; }
        
        Value<decimal> Weight { get; }
        
        Value<string> UnitOrBasisForMeasurementCode { get; }
        
        Value<string> OwnershipCode { get; }
        
        Value<string> SealStatusCode { get; }
        
        Value<string> SealNumber { get; }
        
        Value<string> EquipmentType { get; }
    }
}