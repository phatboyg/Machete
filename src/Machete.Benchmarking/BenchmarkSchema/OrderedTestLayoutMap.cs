namespace Machete.Benchmarking.BenchmarkSchema
{
    using HL7;


    public class OrderedTestLayoutMap :
        HL7LayoutMap<OrderedTestLayout, HL7Entity>
    {
        public OrderedTestLayoutMap()
        {
            Segment(x => x.ORC, 0, x => x.IsRequired());
            Segment(x => x.OBR, 1, x => x.IsRequired());
        }
    }
}