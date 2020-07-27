namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopLDT_2_850 :
        X12Layout
    {
        Segment<LDT> LeadTime { get; }
        
        SegmentList<QTY> QuantityInformation { get; }
        
        Segment<MTX> Text { get; }
        
        SegmentList<REF> ReferenceInformation { get; }
        
        LayoutList<LoopLM_850> LoopLM { get; }
    }
}