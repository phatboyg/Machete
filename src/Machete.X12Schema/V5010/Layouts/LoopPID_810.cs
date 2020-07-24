namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopPID_810 :
        X12Layout
    {
        Segment<PID> ProductOrItemDescription { get; }
        
        SegmentList<MEA> Measurements { get; }
    }
}