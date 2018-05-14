namespace Machete.HL7.Tests.TestSchema
{
    using HL7;


    public interface TestLayoutOptionalOrders :
        HL7Layout
    {
        Segment<MSHSegment> MSH { get; }
        Segment<PIDSegment> PID { get; }
        LayoutList<Order> Orders { get; }
    }
}