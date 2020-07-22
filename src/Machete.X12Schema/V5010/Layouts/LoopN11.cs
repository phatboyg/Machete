namespace Machete.X12Schema.V5010
{
    using Segments;
    using X12;


    public interface LoopN11 :
        X12Layout
    {
        Segment<N11> Name { get; }
        
        SegmentList<AMT> MonetaryAmount { get; }
        
        SegmentList<PCT> PercentAmounts { get; }
        
        LayoutList<LoopN1_2_812> LoopN1 { get; }
    }
}