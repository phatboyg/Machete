namespace Machete.X12Schema.V5010
{
    using X12;


    public interface L2400_837D :
        X12Layout
    {
        Segment<LX> ServiceLineNumber { get; }
        
        Segment<SV3> DentalService { get; }
        
        SegmentList<TOO> ToothInformation { get; }
        
        Segment<DTP> ServiceDate { get; }
        
        Segment<DTP> PriorPlacementDate { get; }
        
        Segment<DTP> AppliancePlacementDate { get; }
        
        Segment<DTP> ReplacementDate { get; }
        
        Segment<DTP> TreatmentStartDate { get; }
        
        Segment<DTP> TreatmentCompletionDate { get; }
        
        Segment<CN1> ContractInformation { get; }
        
        Segment<REF> ServicePredeterminationIndentification { get; }
        
        Segment<REF> PriorAuthorization { get; }
        
        Segment<REF> LineItemControlNumber { get; }
        
        Segment<REF> RepricedClaimNumber { get; }
        
        Segment<REF> AdjustedRepricedClaimNumber { get; }
        
        SegmentList<REF> ReferralNumber { get; }
        
        Segment<AMT> SalesTaxAmount { get; }
        
        SegmentList<K3> FileInformation { get; }
        
        Segment<HCP> LinePricingOrRepricingInfo { get; }
        
        Layout<L2420A_837D> RenderingProvider { get; }
        
        Layout<L2420B_837D> AssistantSurgeon { get; }
        
        Layout<L2420C_837D> SupervisingProvider { get; }
        
        Layout<L2420D_837D> ServiceFacilityLocation { get; }
        
        LayoutList<L2430_837D> LineAdjudicationInformation { get; }
    }
}