namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopPID_820 :
        X12Layout
    {
        Segment<PID> ProductOrITemDescription { get; }
        
        Segment<DTM> DateOrTimeReference { get; }
        
        LayoutList<LoopPCT_820> LoopPCT { get; }
    }
}