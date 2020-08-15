namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class VCMap :
        X12SegmentMap<VC, X12Entity>
    {
        public VCMap()
        {
            Id = "VC";
            Name = "Motor Vehicle Control";
            
            Value(x => x.VehicleIdentificationNumber, 1, x => x.MinLength(1).MaxLength(30));
            Value(x => x.VehicleDeckPositionCode, 2, x => x.FixedLength(2));
            Value(x => x.VehicleTypeCode, 3, x => x.FixedLength(1));
            Value(x => x.DealerCode, 4, x => x.MinLength(2).MaxLength(9));
            Value(x => x.RouteCode, 5, x => x.MinLength(1).MaxLength(13));
            Value(x => x.BayLocation, 6, x => x.MinLength(1).MaxLength(6));
            Value(x => x.AutomotiveManufacturersCode, 7, x => x.FixedLength(2));
            Value(x => x.DamageExceptionIndicator, 8, x => x.FixedLength(1));
            Value(x => x.SupplementalInspectionCode, 9, x => x.FixedLength(1));
            Value(x => x.FactoryCarOrderNumber, 10, x => x.MinLength(6).MaxLength(10));
            Value(x => x.VesselStowageLocation, 11, x => x.MinLength(1).MaxLength(12));
            Value(x => x.EquipmentOrientationCode, 12, x => x.FixedLength(1));
            Value(x => x.LocationIdentifier, 13, x => x.MinLength(1).MaxLength(30));
        }
    }
}