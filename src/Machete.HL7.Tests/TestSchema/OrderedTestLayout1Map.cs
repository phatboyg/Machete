namespace Machete.HL7.Tests.TestSchema
{
    public class OrderedTestLayout1Map :
        HL7LayoutMap<OrderedTestLayout1, HL7Entity>
    {
        public OrderedTestLayout1Map()
        {
            Segment(x => x.ORC, 0, x => x.IsRequired());
            Segment(x => x.OBR, 1, x => x.IsRequired());
        }
    }
}