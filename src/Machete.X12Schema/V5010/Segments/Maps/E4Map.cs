namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class E4Map :
        X12SegmentMap<E4, X12Entity>
    {
        public E4Map()
        {
            Id = "E4";
            Name = "Empty Car Disposition - Pended Destination City";
            
            Value(x => x.CityName, 1, x => x.MinLength(1).MaxLength(60).IsRequired());
            Value(x => x.StateOrProvinceCode, 2, x => x.FixedLength(2).IsRequired());
            Value(x => x.PostalCode, 3, x => x.MinLength(3).MaxLength(15));
            Value(x => x.CountryCode, 4, x => x.MinLength(2).MaxLength(3));
        }
    }
}