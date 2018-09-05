namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class L2420B_837PMap :
        X12LayoutMap<L2420B_837P, X12Entity>
    {
        public L2420B_837PMap()
        {
            Id = "2420B";
            Name = "Purchased Service Provider Name";
            
            Segment(x => x.Provider, 0,
                x => x.Condition = parser => parser.Where(p => p.EntityIdentifierCode.IsEqualTo("QB")));
            Segment(x => x.SecondaryIdentification, 1);
        }
    }
}