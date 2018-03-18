namespace Machete.X12Schema.V5010.Layouts.Maps
{
    using X12;
    using X12.Configuration;


    public class L2100C_270Map :
        X12LayoutMap<L2100C_270, X12Entity>
    {
        public L2100C_270Map()
        {
            Id = "2100C";
            Name = "Subscriber Name";
            
            Segment(x => x.Subscriber, 0, x => x.IsRequired());
            Segment(x => x.AdditionalIdentification, 1);
            Segment(x => x.Address, 2);
            Segment(x => x.GeographicInformation, 3);
            Segment(x => x.ProviderInformation, 4);
            Segment(x => x.DemographicInformation, 5);
            Segment(x => x.MultipleBirthSequenceNumber, 6);
            Segment(x => x.HealthcareDiagnosisCode, 7);
            Segment(x => x.SubscriberDate, 8);
            Layout(x => x.InformationReceiver, 9);
        }
    }
}