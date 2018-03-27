namespace Machete.X12Schema.V5010
{
    using X12;
    
    
    public interface CLM :
        X12Segment
    {
        Value<string> PatientControlNumber { get; }

        Value<decimal> TotalClaimCharges { get; }

        Value<string> ClaimFilingIndicatorCode { get; }
        
        Value<string> NonInstitutionalClaimTypeCode { get; }
        
        Value<FacilityCode> FacilityCode { get; }

        Value<string> ProviderSignatureIndicator { get; }

        Value<string> MedicareAssignmentParticipationCode { get; }

        Value<string> BenefitsAssignmentCertificationIndicator { get; }

        Value<string> ReleaseOfInformationCode { get; }
        
        Value<string> PatientSignatureSourceCode { get; }

        Value<RelatedCauseInformation> RelatedCauseInformation { get; }

        Value<string> SpecialProgramIndicator { get; }
        
        Value<string> LevelOfServiceCode { get; }
        
        Value<string> ProviderAgreementCode { get; }
        
        Value<string> ClaimStatusCode { get; }

        Value<string> ExplanationOfBenefits { get; }
        
        Value<string> ClaimSubmissionReasonCode { get; }

        Value<string> DelayReasonCode { get; }
    }
}