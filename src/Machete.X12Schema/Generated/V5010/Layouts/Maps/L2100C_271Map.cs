namespace Machete.X12Schema.V5010.Layouts.Maps
{
    using X12;
    using X12.Configuration;


    public class L2100C_271Map :
        X12LayoutMap<L2100C_271, X12Entity>
    {
        public L2100C_271Map()
        {
            Id = "2100C";
            Name = "Subscriber Name";
            
            Segment(x => x.Subscriber, 0, x => x.IsRequired());
            Segment(x => x.AdditionalIdentification, 1);
            Segment(x => x.Address, 2);
            Segment(x => x.GeographicInformation, 3);
            Segment(x => x.RequestValidation, 4);
            Segment(x => x.ProviderInformation, 5);
            Segment(x => x.DemographicInformation, 6);
            Segment(x => x.SubscriberRelationship, 7);
            Segment(x => x.HealthcareDiagnosisCode, 8);
            Segment(x => x.SubscriberDate, 9);
            Segment(x => x.MilitaryPersonnelInformation, 10);
            Layout(x => x.EligibilityOrBenefitInformation, 11);
        }
    }
}