namespace Machete.X12Schema.V5010
{
    using X12;


    public interface Loop2110C_271 :
        X12Layout
    {
        Segment<EB> EligibilityOrBenefitInformation { get; }
        
        SegmentList<HSD> HealthcareServicesDelivery { get; }
        
        SegmentList<REF> AdditionalInformation { get; }
        
        SegmentList<DTP> EligibilityOrBenefitDate { get; }
        
        SegmentList<AAA> RequestValidation { get; }
        
        SegmentList<MSG> MessageText { get; }
        
        LayoutList<Loop2115C_271> Loop2115C { get; }
        
        Segment<LS> LoopHeader { get; }
        
        LayoutList<Loop2120C_271> Loop2120C { get; }
        
        Segment<LE> LoopTrailer { get; }
    }
}