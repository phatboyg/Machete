namespace Machete.X12Schema.V5010.Segments.Maps
{
    using X12;
    using X12.Configuration;

    
    public class N4Map :
        X12SegmentMap<N4, X12Entity>
    {
        public N4Map()
        {
            Id = "N4";
            Name = "Geographic Location";
            
            Value(x => x.CityName, 1, x => x.MinLength(2).MaxLength(30));
            Value(x => x.StateOrProvinceCode, 2, x => x.FixedLength(2));
            Value(x => x.PostalCode, 3, x => x.MinLength(3).MaxLength(15));
            Value(x => x.CountryCode, 4, x => x.MinLength(2).MaxLength(3));
            Value(x => x.LocationQualifier, 5, x => x.MinLength(1).MaxLength(2));
            Value(x => x.LocationIdentifier, 6, x => x.MinLength(1).MaxLength(30));
            Value(x => x.CountrySubdivisionCode, 7, x => x.MinLength(1).MaxLength(3));
        }
    }
}