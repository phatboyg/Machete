namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class L2115C_271Map :
        X12LayoutMap<L2115C_271, X12Entity>
    {
        public L2115C_271Map()
        {
            Id = "2115C";
            Name = "Subscriber Eligibility or Benefit Additional Information";
            
            Segment(x => x.EligibilityOrBenefitAdditionalInformation, 0);
        }
    }
}