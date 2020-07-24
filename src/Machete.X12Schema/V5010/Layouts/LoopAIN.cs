namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopAIN :
        X12Layout
    {
        Segment<AIN> Income { get; }
        
        SegmentList<QTY> Quantity { get; }
        
        SegmentList<DTP> DateOrTimePeriod { get; }
    }
}