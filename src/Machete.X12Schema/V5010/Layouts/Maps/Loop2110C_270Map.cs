namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class Loop2110C_270Map :
        X12LayoutMap<Loop2110C_270, X12Entity>
    {
        public Loop2110C_270Map()
        {
            Id = "Loop_2110C_270";
            Name = "Subscriber Eligibility or Benefit Inquiry";
            
            Segment(x => x.EligibilityOrBenefitInquiry, 0);
            Segment(x => x.SpendDownAmount, 1, x =>
                x.Condition = parser => parser.Where(p => p.AmountQualifierCode.IsEqualTo("R")));
            Segment(x => x.SpendDownTotalBilledAmount, 2, x =>
                x.Condition = parser => parser.Where(p => p.AmountQualifierCode.IsEqualTo("PB")));
            Segment(x => x.AdditionalInquiryInformation, 3);
            Segment(x => x.AdditionalInformation, 4);
            Segment(x => x.EligibilityOrBenefitDate, 5);
        }
    }
}