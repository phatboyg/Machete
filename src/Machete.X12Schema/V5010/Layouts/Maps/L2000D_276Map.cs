namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class L2000D_276Map :
        X12LayoutMap<L2000D_276, X12Entity>
    {
        public L2000D_276Map()
        {
            Id = "2000D";
            Name = "Subscriber Level";
            
            Segment(x => x.Level, 0, x => x.IsRequired());
            Segment(x => x.DemographicInformation, 1);
            Layout(x => x.ServiceProviderName, 2);
            Layout(x => x.ClaimStatusTrackingNumber, 3);
        }
    }
}