namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class Loop2000C_271Map :
        X12LayoutMap<Loop2000C_271, X12Entity>
    {
        public Loop2000C_271Map()
        {
            Id = "Loop_2000C_271";
            Name = "Subscriber Level";
            
            Segment(x => x.SubscriberLevel, 0);
            Segment(x => x.SubscriberTraceNumber, 1);
            Layout(x => x.Loop2100C, 2);
            Layout(x => x.Loop2110C, 3);
            Layout(x => x.Loop2115C, 4);
            Layout(x => x.Loop2120C, 5);
        }
    }
}