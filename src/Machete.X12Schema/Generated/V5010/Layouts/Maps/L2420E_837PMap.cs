namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class L2420E_837PMap :
        X12LayoutMap<L2420E_837P, X12Entity>
    {
        public L2420E_837PMap()
        {
            Id = "2420E";
            Name = "Ordering Provider Name";
            
            Segment(x => x.OrderingProvider, 0);
            Segment(x => x.Address, 1);
            Segment(x => x.GeographicInfo, 2);
            Segment(x => x.SecondaryIdentification, 3);
            Segment(x => x.ContactInfo, 4);
        }
    }
}