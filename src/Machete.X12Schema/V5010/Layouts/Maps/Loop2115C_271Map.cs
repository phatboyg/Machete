namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class Loop2115C_271Map :
        X12LayoutMap<Loop2115C_271, X12Entity>
    {
        public Loop2115C_271Map()
        {
            Id = "Loop_2115C_271";
            Name = "Subscriber Eligibility or Benefit Additional Information";
            
            Segment(x => x.EligibilityOrBenefitAdditionalInformation, 0);
        }
    }
}