namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopPO1_870 :
        X12Layout
    {
        Segment<PO1> BaselineItemData { get; }
        
        Segment<CUR> Currency { get; }
        
        Segment<SLN> SublineItemDetail { get; }
        
        SegmentList<PO3> AdditionalItemDetail { get; }
        
        SegmentList<PID> ProductOrItemDescription { get; }
        
        SegmentList<MEA> Measurements { get; }
        
        SegmentList<PKG> MarkingPackagingOrLoading { get; }
        
        LayoutList<LoopISR_2_870> LoopISR { get; }
        
        LayoutList<LoopLX_870> LoopLX { get; }
    }
}