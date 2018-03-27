namespace Machete.X12Schema.V5010
{
    using X12;


    public interface L2110D_270 :
        X12Layout
    {
        Segment<EQ> EligibilityOrBenefitInquiry { get; }
        
        Segment<III> AdditionalInquiryInformation { get; }
        
        Segment<REF> AdditionalInformation { get; }
        
        Segment<DTP> EligibilityOrBenefitDate { get; }
    }
}