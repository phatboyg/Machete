namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class L2310C_837PMap :
        X12LayoutMap<L2310C_837P, X12Entity>
    {
        public L2310C_837PMap()
        {
            Id = "2310C";
            Name = "Service Facility Location Name";
            
            Segment(x => x.FacilityLocation, 0);
            Segment(x => x.Address, 1, x => x.IsRequired());
            Segment(x => x.GeographicInformation, 2, x => x.IsRequired());
            Segment(x => x.SecondaryIdentification, 3);
            Segment(x => x.ContactInformation, 4);
        }
    }
}