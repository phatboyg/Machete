namespace Machete.HL7.Tests.TestSchema
{
    public class OrderMap :
        HL7LayoutMap<Order, HL7Entity>
    {
        public OrderMap()
        {
            Segment(x => x.ORC, 0, x => x.IsRequired());
            Segment(x => x.OBR, 1, x => x.IsRequired());
        }
    }
}