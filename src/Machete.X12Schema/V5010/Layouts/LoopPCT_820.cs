namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopPCT_820 :
        X12Layout
    {
        Segment<PCT> PercentAmounts { get; }
        
        Segment<QTY> Quantity { get; }
        
        LayoutList<LoopAMT_820> LoopAMT { get; }
    }
}