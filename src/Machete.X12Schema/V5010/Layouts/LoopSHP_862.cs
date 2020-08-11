namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopSHP_862 : 
        X12Layout
    {
        Segment<JIT> JustInTimeSchedule { get; }
        
        SegmentList<QTY> ReferenceInformation { get; }
        
        SegmentList<DTM> DateOrTimeReference { get; }
    }
}