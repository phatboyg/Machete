namespace Machete.X12Schema.V5010
{
    using X12;


    public interface L2110D_271 :
        X12Layout
    {
        Segment<EQ> EligibilityOrBenefitInquiry { get; }
        
        Segment<III> AdditionalInquiryInformation { get; }
        
        Segment<REF> AdditionalInformation { get; }
        
        Segment<DTP> EligibilityOrBenefitDate { get; }
        
        SegmentList<AAA> RequestValidation { get; }
        
        SegmentList<MSG> MessageText { get; }
        
        LayoutList<L2115D_271> EligibilityOrBenefitAdditionalInformation { get; }
        
        Segment<LS> LoopHeader { get; }
        
        LayoutList<L2120D_271> BenefitRelatedEntity { get; }
        
        Segment<LE> LoopTrailer { get; }
    }
}