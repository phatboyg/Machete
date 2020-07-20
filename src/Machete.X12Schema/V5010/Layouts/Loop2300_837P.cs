namespace Machete.X12Schema.V5010
{
    using X12;


    public interface Loop2300_837P :
        X12Layout
    {
        Segment<CLM> ClaimInformation { get; }
        
        Segment<DTP> OnsetOfCurrentIllnessDate { get; }
        
        Segment<DTP> InitialTreatmentDate { get; }
        
        Segment<DTP> LastSeenDate { get; }
        
        Segment<DTP> AcuteManifestationDate { get; }
        
        Segment<DTP> AccidentDate { get; }
        
        Segment<DTP> LastMenstrualPeriod { get; }
        
        Segment<DTP> LastXRayDate { get; }
        
        Segment<DTP> HearingAndVisionPrescriptionDate { get; }
        
        Segment<DTP> DisabilityDates { get; }
        
        Segment<DTP> LastWorkedDate { get; }
        
        Segment<DTP> AuthorizedReturnToWork { get; }
        
        Segment<DTP> AdmissionDate { get; }
        
        Segment<DTP> DischargeDate { get; }
        
        Segment<DTP> AssumedRelinquishedCareDates { get; }
        
        Segment<DTP> PropertyAndCasualtyDateOfFirstContact { get; }
        
        Segment<DTP> RepricerReceivedDate { get; }
        
        SegmentList<PWK> ClaimSupplementalInformation { get; }
        
        Segment<CN1> ContractInformation { get; }
        
        Segment<AMT> PatientAmountPaid { get; }
        
        Segment<REF> ServiceAuthorizationExceptionCode { get; }
        
        Segment<REF> MandatoryMedicareCrossoverIndicator { get; }
        
        Segment<REF> MammographyCertificationNumber { get; }
        
        Segment<REF> ReferralNumber { get; }
        
        Segment<REF> PriorAuthorization { get; }
        
        Segment<REF> PayerClaimControlNumber { get; }
        
        Segment<REF> CLIANumber { get; }
        
        Segment<REF> RepricedClaimNumber { get; }
        
        Segment<REF> AdjustedRepricedClaimNumber { get; }
        
        Segment<REF> InvestigationalDeviceExemptionNumber { get; }
        
        Segment<REF> ClaimIdentifierForTransmissionIntermediaries { get; }
        
        Segment<REF> MedicalRecordNumber { get; }
        
        Segment<REF> DemonstrationProjectIdentifier { get; }
        
        Segment<REF> CarePlanOversight { get; }
        
        SegmentList<K3> FileInformation { get; }
        
        Segment<NTE> ClaimNote { get; }
        
        Segment<CR1> AmbulanceTransportInformation { get; }
        
        Segment<CR2> SpinalManipulationServiceInformation { get; }
        
        SegmentList<CRC> AmbulanceCertifications { get; }
        
        SegmentList<CRC> PatientVisionConditionInformation { get; }
        
        Segment<CRC> HomeboundIndicator { get; }
        
        Segment<CRC> EPSDTReferral { get; }
        
        Segment<HI> HealthcareDiagnosisCode { get; }
        
        Segment<HI> AnesthesiaRelatedProcedure { get; }
        
        SegmentList<HI> ConditionInformation { get; }
        
        Segment<HCP> ClaimPricingOrRepricingInformation { get; }
        
        LayoutList<Loop2310A_837P> Loop2310A { get; }
        
        Layout<Loop2310B_837P> Loop2310B { get; }
        
        Layout<Loop2310C_837P> Loop2310C { get; }
        
        Layout<Loop2310D_837P> Loop2310D { get; }
        
        Layout<Loop2310E_837P> Loop2310E { get; }
        
        Layout<Loop2310F_837P> Loop2310F { get; }
        
        LayoutList<Loop2320_837P> Loop2320 { get; }
        
        LayoutList<Loop2400_837P> Loop2400 { get; }
    }
}