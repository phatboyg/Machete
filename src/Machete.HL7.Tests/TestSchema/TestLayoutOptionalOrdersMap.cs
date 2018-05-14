namespace Machete.HL7.Tests.TestSchema
{
    public class TestLayoutOptionalOrdersMap :
        HL7LayoutMap<TestLayoutOptionalOrders, HL7Entity>
    {
        public TestLayoutOptionalOrdersMap()
        {
            Segment(x => x.MSH, 0, x => x.IsRequired());
            Segment(x => x.PID, 1, x => x.IsRequired());
            Layout(x => x.Orders, 2, x => x.IsOptional());
        }
    }
}