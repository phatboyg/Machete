namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class V5Map :
        X12SegmentMap<V5, X12Entity>
    {
        public V5Map()
        {
            Id = "V5";
            Name = "Vessel Identification";
            
            Value(x => x.VesselCodeQualifier, 1, x => x.FixedLength(1).IsRequired());
            
            Value(x => x.VesselCode, 2, x => x.MinLength(1).MaxLength(8).IsRequired());

            Value(x => x.CountryCode, 3, x => x.MinLength(2).MaxLength(3).IsRequired());
        }
    }
}