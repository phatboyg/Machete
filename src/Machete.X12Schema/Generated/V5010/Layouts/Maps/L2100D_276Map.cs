namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class L2100D_276Map :
        X12LayoutMap<L2100D_276, X12Entity>
    {
        public L2100D_276Map()
        {
            Id = "2100D";
            Name = "Subscriber Name";
            
            Segment(x => x.SubscriberName, 0, x => x.IsRequired());
        }
    }
}