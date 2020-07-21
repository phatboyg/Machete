namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class Loop2000D_276Map :
        X12LayoutMap<Loop2000D_276, X12Entity>
    {
        public Loop2000D_276Map()
        {
            Id = "Loop_2000D_276";
            Name = "Subscriber Level";
            
            Segment(x => x.SubscriberLevel, 0);
            Segment(x => x.DemographicInformation, 1);
            Layout(x => x.Loop2100D, 2);
            Layout(x => x.Loop2200D, 3);
        }
    }
}