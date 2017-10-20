namespace Machete.X12Schema.V5010.Segments.Maps
{
    using Machete.X12;
    using Machete.X12.Configuration;

    public class EQMap : X12SegmentMap<EQ, X12Entity>
    {
        public EQMap()
        {
            Id = "EQ";
            Name = "Eligibility Or Benefit Inquiry";
            Value(x => x.ServiceTypeCode, 1, x => x.MinLength(1).MaxLength(2));
            Value(x => x.CompositeMedicalProcedureIdentifier, 2, x => x.MinLength(1));
            Value(x => x.CoverageLevelCode, 3, x => x.FixedLength(3));
            Value(x => x.InsuranceTypeCode, 4, x => x.MinLength(1).MaxLength(3));
        }
    }
}