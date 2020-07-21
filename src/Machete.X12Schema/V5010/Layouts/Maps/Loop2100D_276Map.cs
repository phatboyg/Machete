namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class Loop2100D_276Map :
        X12LayoutMap<Loop2100D_276, X12Entity>
    {
        public Loop2100D_276Map()
        {
            Id = "Loop_2100D_276";
            Name = "Subscriber Name";
            
            Segment(x => x.Subscriber, 0);
        }
    }
}