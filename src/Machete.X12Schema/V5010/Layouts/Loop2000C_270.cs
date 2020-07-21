namespace Machete.X12Schema.V5010
{
    using X12;


    public interface Loop2000C_270 :
        X12Layout
    {
        Segment<HL> SubscriberLevel { get; }
        
        SegmentList<TRN> SubscriberTraceNumber { get; }
        
        LayoutList<Loop2100C_270> Loop2100C { get; }
    }
}