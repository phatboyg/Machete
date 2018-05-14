namespace Machete.HL7.Tests.TestSchema
{
    public class OrderLayout1Map :
        HL7LayoutMap<OrderLayout1, HL7Entity>
    {
        public OrderLayout1Map()
        {
            Segment(x => x.MSH, 0, x => x.IsRequired());
//            Segment(x => x.PID, 1, x => x.IsRequired());
//            Segment(x => x.Unknown, 2, x => x.IsRequired());
            Layout(x => x.Tests, 1, x => x.IsRequired());
        }
    }
}