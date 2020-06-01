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
            
            Segment(x => x.Name, 0,
                x => x.Condition = parser => parser.Where(p => p.EntityIdentifierCode.IsEqualTo("77")));
            Segment(x => x.Address, 1);
            Segment(x => x.GeographicInformation, 2);
            Segment(x => x.SecondaryIdentification, 3);
        }
    }
}