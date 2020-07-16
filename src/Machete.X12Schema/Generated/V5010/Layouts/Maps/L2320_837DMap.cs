namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class L2320_837DMap :
        X12LayoutMap<L2320_837D, X12Entity>
    {
        public L2320_837DMap()
        {
            Id = "2320";
            Name = "Other Subscriber Information";
            
            Segment(x => x.SubscriberInformation, 0);
            Segment(x => x.ClaimLevelAdjustments, 1);
            Segment(x => x.CoordinationOfBenefitsPayerPaidAmount, 2,
                x => x.Condition = parser => parser.Where(p => p.AmountQualifierCode.IsEqualTo("D")));
            Segment(x => x.RemainingPatientLiability, 3,
                x => x.Condition = parser => parser.Where(p => p.AmountQualifierCode.IsEqualTo("EAF")));
            Segment(x => x.CoordinationOfBenefitsTotalNonCoveredAmount, 4,
                x => x.Condition = parser => parser.Where(p => p.AmountQualifierCode.IsEqualTo("A8")));
            Segment(x => x.InsuranceCoverageInformation, 5, x => x.IsRequired());
            Segment(x => x.OutpatientAdjudicationInformation, 6);
            Layout(x => x.Subscriber, 7);
            Layout(x => x.Payer, 8);
            Layout(x => x.PayerReferringProvider, 9);
            Layout(x => x.PayerRenderingProvider, 10);
            Layout(x => x.PayerSupervisingProvider, 11);
            Layout(x => x.PayerBillingProvider, 12);
            Layout(x => x.PayerServiceFacilityLocation, 13);
            Layout(x => x.PayerAssistantSurgeon, 14);
        }
    }
}