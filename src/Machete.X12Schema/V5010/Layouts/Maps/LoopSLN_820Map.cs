namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopSLN_820Map :
        X12LayoutMap<LoopSLN_820, X12Entity>
    {
        public LoopSLN_820Map()
        {
            Id = "Loop_SLN_820";
            Name = "Loop SLN";
            
            Segment(x => x.SublineItemDetail, 0);
            Layout(x => x.LoopREF, 1);
            Layout(x => x.LoopSAC, 2);
        }
    }
}