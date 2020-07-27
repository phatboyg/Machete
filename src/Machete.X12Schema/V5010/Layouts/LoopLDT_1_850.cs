namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopLDT_1_850 :
        X12Layout
    {
        Segment<LDT> LeadTime { get; }
        
        SegmentList<QTY> Quantity { get; }
        
        Segment<MSG> MessageText { get; }
        
        SegmentList<REF> ReferenceIdentification { get; }
    }
}