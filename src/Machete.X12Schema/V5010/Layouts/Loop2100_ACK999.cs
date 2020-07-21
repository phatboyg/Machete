namespace Machete.X12Schema.V5010
{
    using X12;


    public interface Loop2100_ACK999 :
        X12Layout
    {
        Segment<IK3> ErrorIdentification { get; }
        
        SegmentList<CTX> SegmentContext { get; }
        
        Segment<CTX> BusinessUnitIdentifier { get; }
        
        LayoutList<Loop2110_ACK999> Loop2110 { get; }
    }
}