namespace Machete.Benchmarking.BenchmarkSchema
{
    using HL7;
    using HL7Schema.V26;


    public interface OrderLayout :
        HL7Layout
    {
        Segment<MSH> MSH { get; }
        Segment<PID> PID { get; }
        SegmentList<HL7Segment> Unknown { get; }
        LayoutList<OrderedTestLayout> Tests { get; }
    }
}