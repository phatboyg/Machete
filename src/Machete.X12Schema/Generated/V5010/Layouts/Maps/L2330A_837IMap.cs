namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class L2330A_837IMap :
        X12LayoutMap<L2330A_837I, X12Entity>
    {
        public L2330A_837IMap()
        {
            Id = "2330A";
            Name = "Other Subscriber ?Name";
            
            Segment(x => x.Subscriber, 0, x => x.IsRequired());
            Segment(x => x.Address, 1);
            Segment(x => x.GeographicInformation, 2);
            Segment(x => x.SecondaryIdentification, 3);
        }
    }
}