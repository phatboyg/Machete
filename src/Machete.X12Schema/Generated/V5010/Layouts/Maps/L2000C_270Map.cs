namespace Machete.X12Schema.V5010.Layouts.Maps
{
    using X12;
    using X12.Configuration;


    public class L2000C_270Map :
        X12LayoutMap<L2000C_270, X12Entity>
    {
        public L2000C_270Map()
        {
            Id = "2000C";
            Name = "Subscriber Level";
            
            Segment(x => x.SubscriberLevel, 0, x => x.IsRequired());
            Segment(x => x.SubscriberTraceNumber, 1);
            Layout(x => x.InformationReceiver, 2);
        }
    }
}