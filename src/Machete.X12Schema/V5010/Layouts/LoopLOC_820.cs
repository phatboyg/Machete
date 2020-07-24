namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopLOC_820 :
        X12Layout
    {
        Segment<LOC> Location { get; }
        
        LayoutList<LoopPID_820> LoopPID { get; }
    }
}