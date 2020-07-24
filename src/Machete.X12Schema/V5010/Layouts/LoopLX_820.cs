namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopLX_820 :
        X12Layout
    {
        Segment<DED> AssignedNumber { get; }
        
        SegmentList<DED> ReferenceIdentification { get; }
        
        SegmentList<TRN> Trace { get; }
        
        LayoutList<LoopNM1_820> LoopREF { get; }
    }
}