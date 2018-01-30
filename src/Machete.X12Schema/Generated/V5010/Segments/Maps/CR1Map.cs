namespace Machete.X12Schema.V5010.Segments.Maps
{
    using X12;
    using X12.Configuration;

    
    public class CR1Map :
        X12SegmentMap<CR1, X12Entity>
    {
        public CR1Map()
        {
            Id = "CR1";
            Name = "Ambulance Transport Information";
            
            Value(x => x.PatientWeightQualifier, 1, x => x.FixedLength(2));
            // TODO qualifier 1
            Value(x => x.PatientWeight, 2, x => x.MinLength(1).MaxLength(10));
            Value(x => x.Code, 3, x => x.FixedLength(1));
            Value(x => x.ReasonCode, 4, x => x.FixedLength(1).IsRequired());
            Value(x => x.UnitForMeasurementCode, 5, x => x.FixedLength(2));
            // TODO qualifier 5
            Value(x => x.TransportDistance, 6, x => x.FixedLength(1).IsRequired());
            Value(x => x.RoundTripPurposeDescription, 9, x => x.MinLength(1).MaxLength(80));
            Value(x => x.StretcherPurposeDescription, 10, x => x.MinLength(1).MaxLength(80));
        }
    }
}