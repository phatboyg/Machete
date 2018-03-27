namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class L2310E_837PMap :
        X12LayoutMap<L2310E_837P, X12Entity>
    {
        public L2310E_837PMap()
        {
            Id = "2310E";
            Name = "Ambulance Pick-Up Location";
            
            Segment(x => x.PickUpLocation, 0);
            Segment(x => x.Address, 1, x => x.IsRequired());
            Segment(x => x.GeographicInformation, 2, x => x.IsRequired());
        }
    }
}