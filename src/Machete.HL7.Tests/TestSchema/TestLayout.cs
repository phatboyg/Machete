namespace Machete.HL7.Tests.TestSchema
{
    public interface TestLayout :
        HL7Layout
    {
        Segment<MSHSegment> MSH { get; }
        Segment<PIDSegment> PID { get; }
        LayoutList<Order> Orders { get; }
    }
}