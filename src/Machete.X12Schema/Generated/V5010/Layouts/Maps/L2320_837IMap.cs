namespace Machete.X12Schema.V5010.Layouts.Maps
{
    using X12;
    using X12.Configuration;


    public class L2320_837IMap :
        X12LayoutMap<L2320_837I, X12Entity>
    {
        public L2320_837IMap()
        {
            Id = "2320";
            Name = "Other Subscriber Information";
            
            Segment(x => x.SubscriberInformation, 0);
            Segment(x => x.ClaimLevelAdjustments, 1);
            Segment(x => x.CoordinationOfBenefitsPayerPaidAmount, 2);
            Segment(x => x.RemainingPatientLiability, 3);
            Segment(x => x.CoordinationOfBenefitsTotalNonCoveredAmount, 4);
            Segment(x => x.InsuranceCoverageInformation, 5, x => x.IsRequired());
            Segment(x => x.InpatientAdjudicationInformation, 6);
            Segment(x => x.OutpatientAdjudicationInformation, 7);
            Layout(x => x.Subscriber, 8);
            Layout(x => x.Payer, 9);
            Layout(x => x.PayerAttendingProvider, 10);
            Layout(x => x.PayerOperatingPhysician, 11);
            Layout(x => x.PayerOtherOperatingPhysician, 12);
            Layout(x => x.PayerServiceFacilityLocation, 13);
            Layout(x => x.PayerRenderingProvider, 14);
            Layout(x => x.PayerReferringProvider, 15);
            Layout(x => x.PayerBillingProvider, 16);
        }
    }
}