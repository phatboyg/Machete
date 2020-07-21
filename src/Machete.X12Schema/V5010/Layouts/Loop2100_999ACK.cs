namespace Machete.X12Schema.V5010
{
    using X12;


    public interface Loop2100_999ACK :
        X12Layout
    {
        Segment<IK3> ErrorIdentification { get; }
        
        SegmentList<CTX> SegmentContext { get; }
        
        Segment<CTX> BusinessUnitIdentifier { get; }
        
        LayoutList<Loop2110_999ACK> Loop2110 { get; }
    }
}