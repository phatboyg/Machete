namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class L2000_835Map :
        X12LayoutMap<L2000_835, X12Entity>
    {
        public L2000_835Map()
        {
            Id = "2000";
            Name = "Header Number";
            
            Segment(x => x.HeaderNumber, 0);
            Segment(x => x.ProviderSummaryInformation, 1);
            Segment(x => x.ProviderSupplemntalSummaryInformation, 2);
            Layout(x => x.ServiceProviderDetail, 3);
        }
    }
}