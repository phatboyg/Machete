namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class L2110D_270Map :
        X12LayoutMap<L2110D_270, X12Entity>
    {
        public L2110D_270Map()
        {
            Id = "2110D";
            Name = "Subscriber Eligibility or Benefit Inquiry";
            
            Segment(x => x.EligibilityOrBenefitInquiry, 0, x => x.IsRequired());
            Segment(x => x.AdditionalInquiryInformation, 1);
            Segment(x => x.AdditionalInformation, 2);
            Segment(x => x.EligibilityOrBenefitDate, 3);
        }
    }
}