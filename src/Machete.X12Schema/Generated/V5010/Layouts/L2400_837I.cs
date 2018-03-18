namespace Machete.X12Schema.V5010.Layouts
{
    using X12;


    public interface L2400_837I :
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
        
        Layout<L2410_837I> DrugIdentification { get; }
        
        Layout<L2420A_837I> OperatingPhysician { get; }
        
        Layout<L2420B_837I> OtherOperatingPhysician { get; }
        
        Layout<L2420C_837I> RenderingProvider { get; }
        
        Layout<L2420D_837I> ReferringProvider { get; }
        
        LayoutList<L2430_837I> LineAdjudicationInformation { get; }
    }
}