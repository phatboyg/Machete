namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopSLN_820 :
        X12Layout
    {
        Segment<SLN> SublineItemDetail { get; }
        
        LayoutList<LoopREF_1_820> LoopREF { get; }
        
        LayoutList<LoopSAC_820> LoopSAC { get; }
    }
}