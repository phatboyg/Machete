namespace Machete.Benchmarking.BenchmarkSchema
{
    using HL7;
    using HL7Schema.V26;


    public interface OrderedTestLayout :
        HL7Layout
    {
        Segment<ORC> ORC { get; }
        Segment<OBR> OBR { get; }
    }
}