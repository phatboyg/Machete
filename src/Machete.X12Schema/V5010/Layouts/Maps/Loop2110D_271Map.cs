namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class Loop2110D_271Map :
        X12LayoutMap<Loop2110D_271, X12Entity>
    {
        public Loop2110D_271Map()
        {
            Id = "Loop_2100D_271";
            Name = "Dependent Name";
            
            Segment(x => x.EligibilityOrBenefitInquiry, 0);
            Segment(x => x.AdditionalInquiryInformation, 1);
            Segment(x => x.AdditionalInformation, 2);
            Segment(x => x.EligibilityOrBenefitDate, 4);
            Segment(x => x.MessageText, 5);
            Segment(x => x.RequestValidation, 3);
            Layout(x => x.Loop2115D, 6);
            Segment(x => x.LoopHeader, 7);
            Layout(x => x.Loop2120D, 8);
            Segment(x => x.LoopTrailer, 9);
        }
    }
}