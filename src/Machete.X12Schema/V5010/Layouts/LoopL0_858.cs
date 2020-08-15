namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopL0_858 :
        X12Layout
    {
        Segment<L0> LineItemQuantityAndWeight { get; }
        
        SegmentList<L1> RateAndCharges { get; }
        
        SegmentList<MEA> Measurements { get; }
    }
}