namespace Machete.X12Schema.V5010.Layouts
{
    using X12;
    using X12.Schema.Segments;


    public interface L2000D_271 :
        X12Layout
    {
        Segment<HL> DependentLevel { get; }
        
        SegmentList<TRN> DependentTraceNumber { get; }
        
        Layout<L2100D_271> Dependent { get; }
    }
}