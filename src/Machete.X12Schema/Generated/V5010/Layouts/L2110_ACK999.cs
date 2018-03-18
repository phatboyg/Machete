namespace Machete.X12Schema.V5010.Layouts
{
    using X12;


    public interface L2110_ACK999 :
        X12Layout
    {
        Segment<IK4> ImplementationDataElementNote { get; }
        
        SegmentList<CTX> ElementContext { get; }
    }
}