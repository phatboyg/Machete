namespace Machete.X12Schema.V5010.Segments.Maps
{
    using Machete.X12;
    using Machete.X12.Configuration;

    public class SV4Map : X12SegmentMap<SV4, X12Entity>
    {
        public SV4Map()
        {
            Id = "SV4";
            Name = "Drug Service";
            Value(x => x.PrescriptionNumber, 1, x => x.MinLength(1).MaxLength(30).IsRequired());
        }
    }
}