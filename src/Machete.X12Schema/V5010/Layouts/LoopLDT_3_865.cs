namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopLDT_3_865 :
        X12Layout
    {
        Segment<LDT> LeadTime { get; }
        
        SegmentList<MAN> MarksAndNumbersInformation { get; }
        
        SegmentList<QTY> QuantityInformation { get; }
        
        SegmentList<MTX> Text { get; }
    }
}