namespace Machete.X12Schema.V5010
{
    using X12;


    public interface L2300_837D :
        X12Layout
    {
        Segment<CLM> ClaimInformation { get; }
        
        Segment<DTP> AccidentDate { get; }
        
        Segment<DTP> AppliancePlacementDate { get; }
        
        Segment<DTP> ServiceDate { get; }
        
        Segment<DTP> RepricerReceivedDate { get; }
        
        Segment<DN1> OrthodonticTotalMonthsOfTretment { get; }
        
        SegmentList<DN2> ToothStatus { get; }
        
        SegmentList<PWK> ClaimSupplementalInformation { get; }
        
        Segment<CN1> ContractInformation { get; }
        
        Segment<AMT> PatientAmountPaid { get; }
        
        Segment<REF> PredeterminationIdentification { get; }
        
        Segment<REF> ServiceAuthorizationExceptionCode { get; }
        
        Segment<REF> PayerClaimControlNumber { get; }
        
        Segment<REF> ReferralNumber { get; }
        
        Segment<REF> PriorAuthorization { get; }
        
        Segment<REF> RepricedClaimNumber { get; }
        
        Segment<REF> AdjustedRepricedClaimNumber { get; }
        
        Segment<REF> ClaimIdentifierForTransmissionIntermediaries { get; }
        
        SegmentList<K3> FileInformation { get; }
        
        SegmentList<NTE> ClaimNote { get; }
        
        Segment<HI> HealthcareDiagnosisCode { get; }
        
        Segment<HCP> ClaimPricingOrRepricingInformation { get; }
        
        LayoutList<L2310A_837D> ReferringProvider { get; }
        
        Layout<L2310B_837D> RenderingProvider { get; }
        
        Layout<L2310C_837D> ServiceFacilityLocation { get; }
        
        Layout<L2310D_837D> AssistantSurgeon { get; }
        
        Layout<L2310E_837D> SupervisingProvider { get; }
        
        LayoutList<L2320_837D> OtherSubscriberInformation { get; }
        
        LayoutList<L2400_837D> ServiceLineNumber { get; }
    }
}