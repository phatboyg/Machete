namespace Machete.X12Schema.V5010
{
    using X12;


    public interface Loop2000D_271 :
        X12Layout
    {
        Segment<HL> DependentLevel { get; }
        
        SegmentList<TRN> DependentTraceNumber { get; }
        
        Layout<Loop2100D_271> Loop2100D { get; }
    }
}