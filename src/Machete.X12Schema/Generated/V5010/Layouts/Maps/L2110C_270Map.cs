namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class L2110C_270Map :
        X12LayoutMap<L2110C_270, X12Entity>
    {
        public L2110C_270Map()
        {
            Id = "2110C";
            Name = "Subscriber Eligibility or Benefit Inquiry";
            
            Segment(x => x.EligibilityOrBenefitInquiry, 0);
            Segment(x => x.SpendDownAmount, 1);
            Segment(x => x.SpendDownTotalBilledAmount, 2);
            Segment(x => x.AdditionalInquiryInformation, 3);
            Segment(x => x.AdditionalInformation, 4);
            Segment(x => x.EligibilityOrBenefitDate, 5);
        }
    }
}