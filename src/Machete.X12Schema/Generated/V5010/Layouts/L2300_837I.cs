namespace Machete.X12Schema.V5010
{
    using X12;


    public interface L2300_837I :
        X12Layout
    {
        Segment<CLM> ClaimInformation { get; }
        
        Segment<DTP> DischargeHour { get; }
        
        Segment<DTP> StatementDates { get; }
        
        Segment<DTP> AdmissionDateOrHour { get; }
        
        Segment<DTP> RepricerReceivedDate { get; }
        
        SegmentList<CL1> InstitutionalClaimCode { get; }
        
        SegmentList<PWK> ClaimSupplementalInformation { get; }
        
        Segment<CN1> ContractInformation { get; }
        
        Segment<AMT> PatientEstimatedAmountPaid { get; }
        
        Segment<REF> ServiceAuthorizationExceptionCode { get; }
        
        Segment<REF> ReferralNumber { get; }
        
        Segment<REF> PriorAuthorization { get; }
        
        Segment<REF> PayerClaimControlNumber { get; }
        
        Segment<REF> RepricedClaimNumber { get; }
        
        Segment<REF> AdjustedRepricedClaimNumber { get; }
        
        Segment<REF> InvestigationalDeviceExemptionNumber { get; }
        
        Segment<REF> ClaimIdentifierForTransmissionIntermediaries { get; }
        
        Segment<REF> AutoAccidentState { get; }
        
        Segment<REF> MedicalRecordNumber { get; }
        
        Segment<REF> DemonstrationProjectIdentifier { get; }
        
        Segment<REF> PeerReviewOrganizationApprovalNumber { get; }
        
        SegmentList<K3> FileInformation { get; }
        
        SegmentList<NTE> ClaimNote { get; }
        
        Segment<NTE> BillingNote { get; }
        
        Segment<CRC> EPSDTReferral { get; }
        
        Segment<HI> PrincipalDiagnosis { get; }
        
        Segment<HI> AdmittingDiagnosis { get; }
        
        Segment<HI> PatientReasonForVisit { get; }
        
        Segment<HI> ExternalCauseOfInjury { get; }
        
        Segment<HI> DiagnosisRelatedGroupInformation { get; }
        
        SegmentList<HI> OtherDiagnosisInformation { get; }
        
        Segment<HI> PrincipalProcedureInformation { get; }
        
        SegmentList<HI> OtherProcedureInformation { get; }
        
        SegmentList<HI> OccurenceSpanInformation { get; }
        
        SegmentList<HI> OccurenceInformation { get; }
        
        SegmentList<HI> ValueInformation { get; }
        
        SegmentList<HI> ConditionInformation { get; }
        
        SegmentList<HI> TreamentCodeInformation { get; }
        
        Segment<HCP> ClaimPricingOrRepricingInformation { get; }
        
        LayoutList<L2310A_837I> AttendingProvider { get; }
        
        Layout<L2310B_837I> OperatingPhysician { get; }
        
        Layout<L2310C_837I> OtherOperatingPhysician { get; }
        
        Layout<L2310D_837I> RenderingProvider { get; }
        
        Layout<L2310E_837I> ServiceFacilityLocation { get; }
        
        Layout<L2310F_837I> ReferringProvider { get; }
        
        LayoutList<L2320_837I> OtherSubscriberInformation { get; }
        
        LayoutList<L2400_837I> ServiceLineNumber { get; }
    }
}