namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopLDT_3_850 :
        X12Layout
    {
        Segment<LDT> LeadTime { get; }
        
        SegmentList<MAN> MarksAndNumbersInformation { get; }
        
        SegmentList<QTY> QuantityInformation { get; }
        
        Segment<MTX> Text { get; }
        
        SegmentList<REF> ReferenceInformation { get; }
    }
}