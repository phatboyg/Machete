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
            
            Segment(x => x.Name, 0,
                x => x.Condition = parser => parser.Where(p => p.EntityIdentifierCode.IsEqualTo("PW")));
            Segment(x => x.Address, 1);
            Segment(x => x.GeographicInformation, 2);
        }
    }
}