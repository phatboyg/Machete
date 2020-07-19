namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class L2110D_271Map :
        X12LayoutMap<L2110D_271, X12Entity>
    {
        public L2110D_271Map()
        {
            Id = "2100D";
            Name = "Dependent Name";
            
            Segment(x => x.EligibilityOrBenefitInquiry, 0);
            Segment(x => x.AdditionalInquiryInformation, 1);
            Segment(x => x.AdditionalInformation, 2);
            Segment(x => x.EligibilityOrBenefitDate, 4);
            Segment(x => x.MessageText, 5);
            Segment(x => x.RequestValidation, 3);
            Layout(x => x.EligibilityOrBenefitAdditionalInformation, 6);
            Segment(x => x.LoopHeader, 7);
            Layout(x => x.BenefitRelatedEntity, 8);
            Segment(x => x.LoopTrailer, 9);
        }
    }
}