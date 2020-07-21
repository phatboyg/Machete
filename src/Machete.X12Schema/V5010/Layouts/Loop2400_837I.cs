namespace Machete.X12Schema.V5010
{
    using X12;


    public interface Loop2400_837I :
        X12Layout
    {
        Segment<LX> ServiceLineNumber { get; }
        
        Segment<SV2> InstitutionalServiceLine { get; }
        
        SegmentList<PWK> LineSupplementalInformation { get; }
        
        Segment<DTP> ServiceDate { get; }
        
        Segment<REF> LineItemControlNumber { get; }
        
        Segment<REF> RepricedLineItemReferenceNumber { get; }
        
        Segment<REF> AdjustedRepricedLineItemReferenceNumber { get; }
        
        Segment<AMT> ServiceTaxAmount { get; }
        
        Segment<AMT> FacilityTaxAmount { get; }
        
        Segment<NTE> ThirdPartyOrganizationNotes { get; }
        
        Segment<HCP> LinePricingOrRepricingInformation { get; }
        
        Layout<Loop2410_837I> Loop2410 { get; }
        
        Layout<Loop2420A_837I> Loop2420A { get; }
        
        Layout<Loop2420B_837I> Loop2420B { get; }
        
        Layout<Loop2420C_837I> Loop2420C { get; }
        
        Layout<Loop2420D_837I> Loop2420D { get; }
        
        LayoutList<Loop2430_837I> Loop2430 { get; }
    }
}