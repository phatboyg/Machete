namespace Machete.X12Schema.V5010.Layouts.Maps
{
    using X12;
    using X12.Configuration;


    public class L2115D_271Map :
        X12LayoutMap<L2115D_271, X12Entity>
    {
        public L2115D_271Map()
        {
            Id = "2115D";
            Name = "Dependent Eligibility or Benefit Additional Information";
            
            Segment(x => x.EligibilityOrBenefitAdditionalInformation, 0);
        }
    }
}