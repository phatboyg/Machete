namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class Loop2115D_271Map :
        X12LayoutMap<Loop2115D_271, X12Entity>
    {
        public Loop2115D_271Map()
        {
            Id = "Loop_2115D_271";
            Name = "Dependent Eligibility or Benefit Additional Information";
            
            Segment(x => x.EligibilityOrBenefitAdditionalInformation, 0);
        }
    }
}