namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopSLN_861 :
        X12Layout
    {
        Segment<SLN> SublineItemDetail { get; }
        
        SegmentList<PID> ProductOrITemDescription { get; }
        
        LayoutList<LoopLM_861> LoopLM { get; }
    }
}