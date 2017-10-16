namespace Machete.X12Schema.V5010.Segments.Maps
{
    using Machete.X12;
    using Machete.X12.Configuration;

    public class CR1Map : X12SegmentMap<CR1, X12Entity>
    {
        public CR1Map()
        {
            Id = "CR1";
            Name = "Ambulance Transport Information";
            Value(x => x.PatientWeightQualifier, 1, x => x.FixedLength(2));
            // TODO qualifier 1
            Value(x => x.PatientWeight, 2, x => x.MinLength(1));
            Value(x => x.Code, 3, x => x.FixedLength(1).IsRequired());
            Value(x => x.ReasonCode, 4, x => x.FixedLength(1).IsRequired());
            Value(x => x.DistanceQualifier, 5, x => x.FixedLength(2));
            // TODO qualifier 5
            Value(x => x.Distance, 6, x => x.MinLength(1).IsRequired());
            Value(x => x.RoundTripPurpose, 9, x => x.MinLength(1).MaxLength(80));
            Value(x => x.StretcherPurpose, 10, x => x.MinLength(1).MaxLength(80));
        }
    }
}