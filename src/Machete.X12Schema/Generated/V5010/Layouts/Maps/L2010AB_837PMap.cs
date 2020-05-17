namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class L2010AB_837PMap :
        X12LayoutMap<L2010AB_837P, X12Entity>
    {
        public L2010AB_837PMap()
        {
            Id = "2010AB";
            Name = "Pay-to Address Name";
            
            Segment(x => x.AddressName, 0,
                x => x.Condition = parser => parser.Where(p => p.EntityIdentifierCode.IsEqualTo("87")));
            Segment(x => x.Address, 1);
            Segment(x => x.GeographicInformation, 2);
        }
    }
}