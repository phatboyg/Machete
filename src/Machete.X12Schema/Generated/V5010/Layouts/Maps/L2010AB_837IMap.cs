namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class L2010AB_837IMap :
        X12LayoutMap<L2010AB_837I, X12Entity>
    {
        public L2010AB_837IMap()
        {
            Id = "2010AB";
            Name = "Pay-to Address Name";
            
            Segment(x => x.AddressName, 0);
            Segment(x => x.Address, 1, x => x.IsRequired());
            Segment(x => x.GeographicInformation, 2, x => x.IsRequired());
        }
    }
}