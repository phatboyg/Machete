namespace Machete.X12Schema.V5010
{
    using X12;


    public interface Loop2300_837D :
        X12Layout
    {
        Segment<CLM> ClaimInformation { get; }
        
        Segment<DTP> AccidentDate { get; }
        
        Segment<DTP> AppliancePlacementDate { get; }
        
        Segment<DTP> ServiceDate { get; }
        
        Segment<DTP> RepricerReceivedDate { get; }
        
        Segment<DN1> OrthodonticTotalMonthsOfTreatment { get; }
        
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
        
        LayoutList<Loop2310A_837D> Loop2310A { get; }
        
        Layout<Loop2310B_837D> Loop2310B { get; }
        
        Layout<Loop2310C_837D> Loop2310C { get; }
        
        Layout<Loop2310D_837D> Loop2310D { get; }
        
        Layout<Loop2310E_837D> Loop2310E { get; }
        
        LayoutList<Loop2320_837D> Loop2320 { get; }
        
        LayoutList<Loop2400_837D> Loop2400 { get; }
    }
}