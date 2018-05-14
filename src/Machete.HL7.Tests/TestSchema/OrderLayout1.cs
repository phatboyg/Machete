namespace Machete.HL7.Tests.TestSchema
{
    public interface OrderLayout1 :
        HL7Layout
    {
        Segment<MSHSegment> MSH { get; }
        Segment<PIDSegment> PID { get; }
        SegmentList<HL7Segment> Unknown { get; }
        LayoutList<OrderedTestLayout1> Tests { get; }
    }
}