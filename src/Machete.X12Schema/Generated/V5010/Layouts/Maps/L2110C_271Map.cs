namespace Machete.X12Schema.V5010.Layouts.Maps
{
    using X12;
    using X12.Configuration;


    public class L2110C_271Map :
        X12LayoutMap<L2110C_271, X12Entity>
    {
        public L2110C_271Map()
        {
            Id = "2110C";
            Name = "Subscriber Eligibility or Benefit Information";
            
            Segment(x => x.EligibilityOrBenefitInformation, 0, x => x.IsRequired());
            Segment(x => x.HealthcareServicesDelivery, 1);
            Segment(x => x.AdditionalInformation, 2);
            Segment(x => x.EligibilityOrBenefitDate, 3);
            Segment(x => x.RequestValidation, 4);
            Segment(x => x.MessageText, 5);
            Layout(x => x.EligibilityOrBenefitAdditionalInformation, 6);
            Segment(x => x.LoopHeader, 7);
            Layout(x => x.BenefitRelatedEntity, 8);
            Segment(x => x.LoopTrailer, 9);
        }
    }
}