namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;

    
    public class CL1Map :
        X12SegmentMap<CL1, X12Entity>
    {
        public CL1Map()
        {
            Id = "CL1";
            Name = "Institutional Claim Code";
            
            Value(x => x.AdmissionTypeCode, 1, x => x.FixedLength(1));
            Value(x => x.AdmissionSourceCode, 2, x => x.FixedLength(1));
            Value(x => x.PatientStatusCode, 3, x => x.MinLength(1).MaxLength(2));
        }
    }
}