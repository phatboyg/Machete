namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class Loop2320_837PMap :
        X12LayoutMap<Loop2320_837P, X12Entity>
    {
        public Loop2320_837PMap()
        {
            Id = "Loop_2320_837P";
            Name = "Other Subscriber Information";
            
            Segment(x => x.SubscriberInformation, 0);
            Segment(x => x.ClaimLevelAdjustments, 1);
            Segment(x => x.CoordinationOfBenefitsPayerPaidAmount, 2,
                x => x.Condition = parser => parser.Where(p => p.AmountQualifierCode.IsEqualTo("D")));
            Segment(x => x.CoordinationOfBenefitsTotalNonCoveredAmount, 3,
                x => x.Condition = parser => parser.Where(p => p.AmountQualifierCode.IsEqualTo("A8")));
            Segment(x => x.RemainingPatientLiability, 4,
                x => x.Condition = parser => parser.Where(p => p.AmountQualifierCode.IsEqualTo("EAF")));
            Segment(x => x.InsuranceCoverageInformation, 5);
            Segment(x => x.OutpatientAdjudicationInformation, 6);
            Layout(x => x.Loop2330A, 7);
            Layout(x => x.Loop2330B, 8);
            Layout(x => x.Loop2330C, 9);
            Layout(x => x.Loop2330D, 10);
            Layout(x => x.Loop2330E, 11);
            Layout(x => x.Loop2330F, 12);
            Layout(x => x.Loop2330G, 13);
        }
    }
}