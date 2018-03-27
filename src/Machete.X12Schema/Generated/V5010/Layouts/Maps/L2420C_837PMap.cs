namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class L2420C_837PMap :
        X12LayoutMap<L2420C_837P, X12Entity>
    {
        public L2420C_837PMap()
        {
            Id = "2420C";
            Name = "Service Facility Location Name";
            
            Segment(x => x.LocationName, 0);
            Segment(x => x.Address, 1, x => x.IsRequired());
            Segment(x => x.GeographicInfo, 2, x => x.IsRequired());
            Segment(x => x.SecondaryIdentification, 3);
        }
    }
}