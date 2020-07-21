namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class Loop2110D_270Map :
        X12LayoutMap<Loop2110D_270, X12Entity>
    {
        public Loop2110D_270Map()
        {
            Id = "Loop_2110D_270";
            Name = "Subscriber Eligibility or Benefit Inquiry";
            
            Segment(x => x.EligibilityOrBenefitInquiry, 0);
            Segment(x => x.AdditionalInquiryInformation, 1);
            Segment(x => x.AdditionalInformation, 2);
            Segment(x => x.EligibilityOrBenefitDate, 3);
        }
    }
}