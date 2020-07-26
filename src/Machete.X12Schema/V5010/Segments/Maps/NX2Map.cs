namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class NX2Map :
        X12SegmentMap<NX2, X12Entity>
    {
        public NX2Map()
        {
            Id = "NX2";
            Name = "Location ID Component";
            
            Value(x => x.AddressComponentQualifier, 1, x => x.FixedLength(2).IsRequired());
            Value(x => x.AddressInformation, 2, x => x.MinLength(1).MaxLength(55).IsRequired());
            Value(x => x.CountyDesignator, 3, x => x.FixedLength(5));
        }
    }
}