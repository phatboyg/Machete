namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class Loop2110C_271Map :
        X12LayoutMap<Loop2110C_271, X12Entity>
    {
        public Loop2110C_271Map()
        {
            Id = "Loop_2110C_271";
            Name = "Subscriber Eligibility or Benefit Information";
            
            Segment(x => x.EligibilityOrBenefitInformation, 0);
            Segment(x => x.HealthcareServicesDelivery, 1);
            Segment(x => x.AdditionalInformation, 2);
            Segment(x => x.EligibilityOrBenefitDate, 3);
            Segment(x => x.RequestValidation, 4);
            Segment(x => x.MessageText, 5);
            Layout(x => x.Loop2115C, 6);
            Segment(x => x.LoopHeader, 7);
            Layout(x => x.Loop2120C, 8);
            Segment(x => x.LoopTrailer, 9);
        }
    }
}