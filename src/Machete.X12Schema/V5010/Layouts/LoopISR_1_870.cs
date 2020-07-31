namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopISR_1_870 :
        X12Layout
    {
        Segment<ISR> ItemStatusReport { get; }
        
        SegmentList<PID> ProductOrItemDescription { get; }
        
        Segment<QTY> QuantityInformation { get; }
    }
}