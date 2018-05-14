namespace Machete.Benchmarking.BenchmarkSchema
{
    using HL7;


    public class OrderLayoutMap :
        HL7LayoutMap<OrderLayout, HL7Entity>
    {
        public OrderLayoutMap()
        {
            Segment(x => x.MSH, 0, x => x.IsRequired());
//            Segment(x => x.PID, 1, x => x.IsRequired());
//            Segment(x => x.Unknown, 2, x => x.IsRequired());
            Layout(x => x.Tests, 1, x => x.IsRequired());
        }
    }
}