namespace Machete.X12Schema.V5010
{
    using X12;


    public interface L2000C_271 :
        X12Layout
    {
        Segment<HL> SubscriberLevel { get; }
        
        SegmentList<TRN> SubscriberTraceNumber { get; }
        
        LayoutList<L2100C_271> Subscriber { get; }
        
        LayoutList<L2110C_271> SubscriberEligibilityOrBenefitInformation { get; }
        
        LayoutList<L2115C_271> SubscriberEligibilityOrBenefitAdditionalInformation { get; }
        
        LayoutList<L2120C_271> SubscriberBenefitRelatedEntity { get; }
    }
}