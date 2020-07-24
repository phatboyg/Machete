namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopN9_820 :
        X12Layout
    {
        SegmentList<N9> ReferenceIdentification { get; }
        
        LayoutList<LoopAMT_820> LoopAMT { get; }
        
        LayoutList<LoopN1_2_820> LoopN1 { get; }
    }
}