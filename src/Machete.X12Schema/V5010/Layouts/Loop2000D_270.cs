namespace Machete.X12Schema.V5010
{
    using X12;


    public interface Loop2000D_270 :
        X12Layout
    {
        Segment<HL> DependentLevel { get; }
        
        SegmentList<TRN> DependentTraceNumber { get; }
        
        Layout<Loop2100D_270> Loop2100D { get; }
    }
}