namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class Loop2420E_837PMap :
        X12LayoutMap<Loop2420E_837P, X12Entity>
    {
        public Loop2420E_837PMap()
        {
            Id = "2420E";
            Name = "Ordering Provider Name";
            
            Segment(x => x.OrderingProvider, 0,
                x => x.Condition = parser => parser.Where(p => p.EntityIdentifierCode.IsEqualTo("DK")));
            Segment(x => x.Address, 1);
            Segment(x => x.GeographicInformation, 2);
            Segment(x => x.SecondaryIdentification, 3);
            Segment(x => x.ContactInformation, 4);
        }
    }
}