namespace Machete.X12Schema.V5010
{
    using X12;


    public interface VC :
        X12Segment
    {
        Value<string> VehicleIdentificationNumber { get; }
        
        Value<string> VehicleDeckPositionCode { get; }
        
        Value<string> VehicleTypeCode { get; }
        
        Value<string> DealerCode { get; }
        
        Value<string> RouteCode { get; }
        
        Value<string> BayLocation { get; }
        
        Value<string> AutomotiveManufacturersCode { get; }
        
        Value<string> DamageExceptionIndicator { get; }
        
        Value<string> SupplementalInspectionCode { get; }
        
        Value<string> FactoryCarOrderNumber { get; }
        
        Value<string> VesselStowageLocation { get; }
        
        Value<string> EquipmentOrientationCode { get; }
        
        Value<string> LocationIdentifier { get; }
    }
}