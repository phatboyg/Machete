namespace Machete.X12Schema.V5010
{
    using X12;


    public interface Loop2110_999ACK :
        X12Layout
    {
        Segment<IK4> ImplementationDataElementNote { get; }
        
        SegmentList<CTX> ElementContext { get; }
    }
}