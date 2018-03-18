namespace Machete.X12Schema.V5010.Layouts
{
    using X12;


    public interface L2110C_271 :
        X12Layout
    {
        Segment<EB> EligibilityOrBenefitInformation { get; }
        
        SegmentList<HSD> HealthcareServicesDelivery { get; }
        
        SegmentList<REF> AdditionalInformation { get; }
        
        SegmentList<DTP> EligibilityOrBenefitDate { get; }
        
        SegmentList<AAA> RequestValidation { get; }
        
        SegmentList<MSG> MessageText { get; }
        
        LayoutList<L2115C_271> EligibilityOrBenefitAdditionalInformation { get; }
        
        Segment<LS> LoopHeader { get; }
        
        LayoutList<L2120C_271> BenefitRelatedEntity { get; }
        
        Segment<LE> LoopTrailer { get; }
    }
}