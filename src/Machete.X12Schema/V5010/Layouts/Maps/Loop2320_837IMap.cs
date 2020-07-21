namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class Loop2320_837IMap :
        X12LayoutMap<Loop2320_837I, X12Entity>
    {
        public Loop2320_837IMap()
        {
            Id = "Loop_2320_837I";
            Name = "Other Subscriber Information";
            
            Segment(x => x.SubscriberInformation, 0);
            Segment(x => x.ClaimLevelAdjustments, 1);
            Segment(x => x.CoordinationOfBenefitsPayerPaidAmount, 2,
                x => x.Condition = parser => parser.Where(p => p.AmountQualifierCode.IsEqualTo("D")));
            Segment(x => x.RemainingPatientLiability, 3,
                x => x.Condition = parser => parser.Where(p => p.AmountQualifierCode.IsEqualTo("EAF")));
            Segment(x => x.CoordinationOfBenefitsTotalNonCoveredAmount, 4,
                x => x.Condition = parser => parser.Where(p => p.AmountQualifierCode.IsEqualTo("A8")));
            Segment(x => x.InsuranceCoverageInformation, 5);
            Segment(x => x.InpatientAdjudicationInformation, 6);
            Segment(x => x.OutpatientAdjudicationInformation, 7);
            Layout(x => x.Loop2330A, 8);
            Layout(x => x.Loop2330B, 9);
            Layout(x => x.Loop2330C, 10);
            Layout(x => x.Loop2330D, 11);
            Layout(x => x.Loop2330E, 12);
            Layout(x => x.Loop2330F, 13);
            Layout(x => x.Loop2330G, 14);
            Layout(x => x.Loop2330H, 15);
            Layout(x => x.Loop2330I, 16);
        }
    }
}