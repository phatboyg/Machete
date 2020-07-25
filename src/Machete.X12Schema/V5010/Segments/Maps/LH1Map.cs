namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LH1Map :
        X12SegmentMap<LH1, X12Entity>
    {
        public LH1Map()
        {
            Id = "LH1";
            Name = "Hazardous Identification Information";
            
            Value(x => x.UnitOrBasisForMeasurementCode1, 1, x => x.FixedLength(2).IsRequired());
            Value(x => x.LadingQuantity, 2, x => x.MinLength(1).MaxLength(7).IsRequired());
            Value(x => x.UnitedNationsOrNorthAmericaIdentificationCode, 3, x => x.FixedLength(6));
            Value(x => x.HazardousMaterialsPage, 4, x => x.MinLength(1).MaxLength(6));
            Value(x => x.CommodityCode, 5, x => x.MinLength(1).MaxLength(30));
            Value(x => x.UnitOrBasisForMeasurementCode2, 6, x => x.FixedLength(2));
            Value(x => x.Quantity, 7, x => x.MinLength(1).MaxLength(15));
            Value(x => x.CompartmentIdCode, 8, x => x.FixedLength(1));
            Value(x => x.ResidueIndicatorCode, 9, x => x.FixedLength(1));
            Value(x => x.PackingGroupCode, 10, x => x.MinLength(1).MaxLength(3));
            Value(x => x.InterimHazardousMaterialRegulatoryNumber, 11, x => x.MinLength(1).MaxLength(5));
        }
    }
}