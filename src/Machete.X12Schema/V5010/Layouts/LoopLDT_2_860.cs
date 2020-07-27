namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopLDT_2_860 :
        X12Layout
    {
        Segment<LDT> LeadTime { get; }
        
        SegmentList<QTY> Quantity { get; }
        
        SegmentList<MTX> Text { get; }
        
        SegmentList<REF> ReferenceInformation { get; }
        
        LayoutList<LoopLM_860> LoopLM { get; }
    }
}