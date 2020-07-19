namespace Machete.X12Schema.V5010.Segments.Maps
{
    using X12;
    using X12.Configuration;


    public class PKGMap :
        X12SegmentMap<PKG, X12Entity>
    {
        public PKGMap()
        {
            Id = "PKG";
            Name = "Marking, Packaging, Loading";
            
            Value(x => x.ItemDescriptionType, 1, x => x.FixedLength(1));
            Value(x => x.PackagingCharacteristicCode, 2, x => x.MinLength(1).MaxLength(5));
            Value(x => x.AgencyQualifierCode, 3, x => x.FixedLength(2));
            Value(x => x.PackagingDescriptionCode, 4, x => x.MinLength(1).MaxLength(7));
            Value(x => x.Description, 5, x => x.MinLength(1).MaxLength(80));
            Value(x => x.UnitLoadOptionCode, 6, x => x.FixedLength(2));
        }
    }
}