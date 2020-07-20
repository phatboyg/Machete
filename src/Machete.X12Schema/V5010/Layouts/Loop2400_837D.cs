namespace Machete.X12Schema.V5010
{
    using X12;


    public interface Loop2400_837D :
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
        
        Segment<REF> ServicePredeterminationIdentification { get; }
        
        Segment<REF> PriorAuthorization { get; }
        
        Segment<REF> LineItemControlNumber { get; }
        
        Segment<REF> RepricedClaimNumber { get; }
        
        Segment<REF> AdjustedRepricedClaimNumber { get; }
        
        SegmentList<REF> ReferralNumber { get; }
        
        Segment<AMT> SalesTaxAmount { get; }
        
        SegmentList<K3> FileInformation { get; }
        
        Segment<HCP> LinePricingOrRepricingInformation { get; }
        
        Layout<Loop2420A_837D> Loop2420A { get; }
        
        Layout<Loop2420B_837D> Loop2420B { get; }
        
        Layout<Loop2420C_837D> Loop2420C { get; }
        
        Layout<Loop2420D_837D> Loop2420D { get; }
        
        LayoutList<Loop2430_837D> Loop2430 { get; }
    }
}