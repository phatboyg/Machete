namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class L2420G_837PMap :
        X12LayoutMap<L2420G_837P, X12Entity>
    {
        public L2420G_837PMap()
        {
            Id = "2420G";
            Name = "Ambulance Pick Up Location";
                                    
            Segment(x => x.PickUpLocation, 0,
                x => x.Condition = parser => parser.Where(p => p.EntityIdentifierCode.IsEqualTo("PW")));
            Segment(x => x.Address, 1, x => x.IsRequired());
            Segment(x => x.GeographicInfo, 2, x => x.IsRequired());
        }
    }
}