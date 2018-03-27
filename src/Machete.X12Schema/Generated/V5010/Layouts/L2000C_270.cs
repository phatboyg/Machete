namespace Machete.X12Schema.V5010
{
    using X12;


    public interface L2000C_270 :
        X12Layout
    {
        Segment<HL> SubscriberLevel { get; }
        
        SegmentList<TRN> SubscriberTraceNumber { get; }
        
        LayoutList<L2100C_270> InformationReceiver { get; }
    }
}