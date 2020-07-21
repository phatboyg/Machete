namespace Machete.X12Schema.V5010
{
    using X12;


    public interface Loop2000C_271 :
        X12Layout
    {
        Segment<HL> SubscriberLevel { get; }
        
        SegmentList<TRN> SubscriberTraceNumber { get; }
        
        LayoutList<Loop2100C_271> Loop2100C { get; }
        
        LayoutList<Loop2110C_271> Loop2110C { get; }
        
        LayoutList<Loop2115C_271> Loop2115C { get; }
        
        LayoutList<Loop2120C_271> Loop2120C { get; }
    }
}