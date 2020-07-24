namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopENT_820 :
        X12Layout
    {
        Segment<ENT> Entity { get; }
        
        LayoutList<LoopNM1_820> LoopNM1 { get; }
        
        LayoutList<LoopADX_1_820> LoopADX { get; }
        
        LayoutList<LoopRMR_820> LoopRMR { get; }
    }
}