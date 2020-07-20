namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class Loop2420B_837PMap :
        X12LayoutMap<Loop2420B_837P, X12Entity>
    {
        public Loop2420B_837PMap()
        {
            Id = "Loop_2420B_837P";
            Name = "Purchased Service Provider Name";
            
            Segment(x => x.PurchasedServiceProvider, 0,
                x => x.Condition = parser => parser.Where(p => p.EntityIdentifierCode.IsEqualTo("QB")));
            Segment(x => x.SecondaryIdentification, 1);
        }
    }
}