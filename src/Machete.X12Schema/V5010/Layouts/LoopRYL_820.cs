namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopRYL_820 :
        X12Layout
    {
        SegmentList<RYL> RoyaltyPayment { get; }
        
        LayoutList<LoopNM1_820> LoopAMT { get; }
    }
}