namespace Machete.X12Schema.V5010.Segments.Maps
{
    using X12;
    using X12.Configuration;

    
    public class CLMMap :
        X12SegmentMap<CLM, X12Entity>
    {
        public CLMMap()
        {
            Id = "CLM";
            Name = "Claim Information";
            
            Value(x => x.PatientControlNumber, 1, x => x.MinLength(1).MaxLength(38).IsRequired());
            Value(x => x.TotalClaimCharges, 2, x => x.FixedLength(1));
            Value(x => x.ClaimFilingIndicatorCode, 3, x => x.MinLength(1).MaxLength(2));
            Value(x => x.NonInstitutionalClaimTypeCode, 4, x => x.MinLength(1).MaxLength(2));
            Entity(x => x.FacilityCode, 5);
            Value(x => x.ProviderSignatureIndicator, 6, x => x.FixedLength(1).IsRequired());
            Value(x => x.MedicareAssignmentParticipationCode, 7, x => x.FixedLength(1));
            Value(x => x.BenefitsAssignmentCertificationIndicator, 8, x => x.FixedLength(1));
            Value(x => x.ReleaseOfInformationCode, 9, x => x.FixedLength(1));
            Entity(x => x.RelatedCauseInformation, 11);
            Value(x => x.SpecialProgramIndicator, 12, x => x.MinLength(2).MaxLength(3));
            Value(x => x.LevelOfServiceCode, 14, x => x.MinLength(1).MaxLength(3));
            Value(x => x.ProviderAgreementCode, 16, x => x.FixedLength(1));
            Value(x => x.ClaimStatusCode, 17, x => x.MinLength(1).MaxLength(2));
            Value(x => x.ExplanationOfBenefits, 18, x => x.FixedLength(1));
            Value(x => x.ClaimSubmissionReasonCode, 19, x => x.FixedLength(2));
            Value(x => x.DelayReasonCode, 20, x => x.MinLength(1).MaxLength(2));
        }
    }
}