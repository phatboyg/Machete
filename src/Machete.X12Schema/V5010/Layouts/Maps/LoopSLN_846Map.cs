namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopSLN_846Map :
        X12LayoutMap<LoopSLN_846, X12Entity>
    {
        public LoopSLN_846Map()
        {
            Id = "Loop_SLN_846";
            Name = "Loop SLN";
            
            Segment(x => x.SublineItemDetail, 0);
            Segment(x => x.ItemDescription, 1);
            Segment(x => x.Measurements, 2);
            Segment(x => x.MarkingPackagingOrLoading, 3);
            Layout(x => x.LoopMAN, 4);
        }
    }
}