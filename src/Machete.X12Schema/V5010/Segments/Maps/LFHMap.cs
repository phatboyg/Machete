namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LFHMap :
        X12SegmentMap<LFH, X12Entity>
    {
        public LFHMap()
        {
            Id = "LFH";
            Name = "Freeform Hazardous Material Information";
            
            Value(x => x.HazardousMaterialShipmentInformationQualifier, 1, x => x.FixedLength(3).IsRequired());
            Value(x => x.HazardousMaterialShipmentInformation1, 2, x => x.MinLength(1).MaxLength(25).IsRequired());
            Value(x => x.HazardousMaterialShipmentInformation2, 3, x => x.MinLength(1).MaxLength(25));
            Value(x => x.HazardZoneCode, 4, x => x.FixedLength(1));
            Value(x => x.UnitOrBasisForMeasurementCode, 5, x => x.FixedLength(2));
            Value(x => x.Quantity1, 6, x => x.MinLength(1).MaxLength(15));
            Value(x => x.Quantity2, 7, x => x.MinLength(1).MaxLength(15));
        }
    }
}