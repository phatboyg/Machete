namespace Machete.X12Schema.V5010
{
    using X12;


    public interface Loop2110D_271 :
        X12Layout
    {
        Segment<EQ> EligibilityOrBenefitInquiry { get; }
        
        Segment<III> AdditionalInquiryInformation { get; }
        
        Segment<REF> AdditionalInformation { get; }
        
        Segment<DTP> EligibilityOrBenefitDate { get; }
        
        SegmentList<AAA> RequestValidation { get; }
        
        SegmentList<MSG> MessageText { get; }
        
        LayoutList<Loop2115D_271> Loop2115D { get; }
        
        Segment<LS> LoopHeader { get; }
        
        LayoutList<Loop2120D_271> Loop2120D { get; }
        
        Segment<LE> LoopTrailer { get; }
    }
}