namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;

    
    public class EQMap :
        X12SegmentMap<EQ, X12Entity>
    {
        public EQMap()
        {
            Id = "EQ";
            Name = "Eligibility Or Benefit Inquiry";
            
            Value(x => x.ServiceTypeCode, 1, x => x.MinLength(1).MaxLength(2));
            Value(x => x.CompositeMedicalProcedureIdentifier, 2, x => x.FixedLength(1));
            Value(x => x.CoverageLevelCode, 3, x => x.FixedLength(3));
            Value(x => x.InsuranceTypeCode, 4, x => x.MinLength(1).MaxLength(3));
        }
    }
}