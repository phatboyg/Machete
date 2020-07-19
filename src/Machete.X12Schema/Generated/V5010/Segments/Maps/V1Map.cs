namespace Machete.X12Schema.V5010.Segments.Maps
{
    using X12;
    using X12.Configuration;


    public class V1Map :
        X12SegmentMap<V1, X12Entity>
    {
        public V1Map()
        {
            Id = "V1";
            Name = "Vessel Identification";
            
            Value(x => x.VesselCode, 1, x => x.MinLength(1).MaxLength(8));
            Value(x => x.VesselName, 2, x => x.MinLength(2).MaxLength(28));
            Value(x => x.CountryCode, 3, x => x.MinLength(2).MaxLength(3));
            Value(x => x.VesselName, 4, x => x.MinLength(2).MaxLength(10));
            Value(x => x.CountryCode, 5, x => x.MinLength(2).MaxLength(4));
            Value(x => x.FlightOrVoyageNumber, 6, x => x.FixedLength(1));
            Value(x => x.StandardCarrierAlphaCode, 7, x => x.FixedLength(2));
            Value(x => x.VesselRequirementCode, 8, x => x.FixedLength(1));
            Value(x => x.VesselTypeCode, 9, x => x.FixedLength(2));
            Value(x => x.VesselCodeQualifier, 10, x => x.FixedLength(1));
            Value(x => x.TransportationMethodOrTypeCode, 11, x => x.MinLength(1).MaxLength(2));
        }
    }
}