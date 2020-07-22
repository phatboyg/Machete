namespace Machete.X12Schema.V5010
{
    using Segments;
    using X12;


    public interface LoopN1_2_812 :
        X12Layout
    {
        Segment<N1> Name { get; }
        
        SegmentList<AMT> MonetaryAmount { get; }
        
        SegmentList<PCT> PercentAmounts { get; }
    }
}