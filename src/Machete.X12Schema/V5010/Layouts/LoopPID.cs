namespace Machete.X12Schema.V5010
{
    using Segments;
    using X12;


    public interface LoopPID :
        X12Layout
    {
        Segment<PID> ProductOrItemDescription { get; }
        
        SegmentList<MEA> Measurements { get; }
    }
}