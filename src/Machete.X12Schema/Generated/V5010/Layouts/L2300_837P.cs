namespace Machete.X12Schema.V5010
{
    using X12;


    public interface L2300_837P :
        X12Layout
    {
        Segment<CLM> ClaimInformation { get; }
        
        Segment<DTP> OnsetOfCurrentIllnessDate { get; }
        
        Segment<DTP> InitialTreatmentDate { get; }
        
        Segment<DTP> LastSeenDate { get; }
        
        Segment<DTP> AcuteManifestationDate { get; }
        
        Segment<DTP> AccidentDate { get; }
        
        Segment<DTP> LastMensrualPeriod { get; }
        
        Segment<DTP> LastXRayDate { get; }
        
        Segment<DTP> HearingVisionPrescriptionDate { get; }
        
        Segment<DTP> DisabilityDates { get; }
        
        Segment<DTP> LastWorkedDate { get; }
        
        Segment<DTP> AuthorizedReturnToWork { get; }
        
        Segment<DTP> AdmissionDate { get; }
        
        Segment<DTP> DischargeDate { get; }
        
        Segment<DTP> AssumedRelinquishedCareDates { get; }
        
        Segment<DTP> PropertyAndCasualtyDateOfFirstContact { get; }
        
        Segment<DTP> RepricerReceivedDate { get; }
        
        SegmentList<PWK> ClaimSupplementalInfo { get; }
        
        Segment<CN1> ContractInfo { get; }
        
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
        
        SegmentList<K3> FileInfo { get; }
        
        Segment<NTE> ClaimNote { get; }
        
        Segment<CR1> AmbulanceTransportInfo { get; }
        
        Segment<CR2> SpinalManipulationServiceInfo { get; }
        
        SegmentList<CRC> AmbulanceCertification { get; }
        
        SegmentList<CRC> PatientConditionInfo { get; }
        
        Segment<CRC> HomeboundIndicator { get; }
        
        Segment<CRC> EPSDTReferral { get; }
        
        Segment<HI> HealthCareDiagnosisCode { get; }
        
        Segment<HI> AnesthesiaRelatedProcedure { get; }
        
        SegmentList<HI> ConditionInfo { get; }
        
        Segment<HCP> ClaimPricingOrRepricingInfo { get; }
        
        LayoutList<L2310A_837P> ReferringProvider { get; }
        
        Layout<L2310B_837P> RenderingProvider { get; }
        
        Layout<L2310C_837P> ServiceFacilityLocation { get; }
        
        Layout<L2310D_837P> SupervisingProvider { get; }
        
        Layout<L2310E_837P> AmbulancePickUpLocation { get; }
        
        Layout<L2310F_837P> AmbulanceDropOffLocation { get; }
        
        LayoutList<L2320_837P> OtherSubscriberInfo { get; }
        
        LayoutList<L2400_837P> ServiceLineNumber { get; }
    }
}