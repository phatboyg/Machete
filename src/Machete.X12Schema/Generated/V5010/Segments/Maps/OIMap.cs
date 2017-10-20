namespace Machete.X12Schema.V5010.Segments.Maps
{
    using Machete.X12;
    using Machete.X12.Configuration;

    public class OIMap : X12SegmentMap<OI, X12Entity>
    {
        public OIMap()
        {
            Id = "OI";
            Name = "Other Health Insurance Information";
            Value(x => x.BenefitsAssignmentCertificationIndicator, 3, x => x.FixedLength(1).IsRequired());
            Value(x => x.ReleaseOfInformationCode, 6, x => x.FixedLength(1).IsRequired());
        }
    }
}