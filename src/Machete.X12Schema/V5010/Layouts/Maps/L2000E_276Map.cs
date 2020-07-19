namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class L2000E_276Map :
        X12LayoutMap<L2000E_276, X12Entity>
    {
        public L2000E_276Map()
        {
            Id = "2000E";
            Name = "Dependent Level";
            
            Segment(x => x.Level, 0);
            Segment(x => x.DemographicInformation, 1, x => x.IsRequired());
            Layout(x => x.ServiceProviderName, 2);
            Layout(x => x.ClaimStatusTrackingNumber, 3);
        }
    }
}