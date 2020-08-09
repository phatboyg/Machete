namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopSLN_861Map :
        X12LayoutMap<LoopSLN_861, X12Entity>
    {
        public LoopSLN_861Map()
        {
            Id = "Loop_SLN_861";
            Name = "Loop SLN";
            
            Segment(x => x.SublineItemDetail, 0);
            Segment(x => x.ProductOrITemDescription, 1);
            Layout(x => x.LoopLM, 2);
        }
    }
}