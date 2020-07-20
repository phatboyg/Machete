namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class Loop2310E_837PMap :
        X12LayoutMap<Loop2310E_837P, X12Entity>
    {
        public Loop2310E_837PMap()
        {
            Id = "Loop_2310E_837P";
            Name = "Ambulance Pick-Up Location";
            
            Segment(x => x.AmbulancePickUpLocation, 0,
                x => x.Condition = parser => parser.Where(p => p.EntityIdentifierCode.IsEqualTo("PW")));
            Segment(x => x.Address, 1);
            Segment(x => x.GeographicInformation, 2);
        }
    }
}