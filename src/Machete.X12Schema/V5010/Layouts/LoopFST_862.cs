namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopFST_862 : 
        X12Layout
    {
        Segment<FST> ForecastSchedule { get; }
        
        SegmentList<DTM> DateOrTimeReference { get; }
        
        LayoutList<LoopSHP_862> LoopSHP { get; }
    }
}