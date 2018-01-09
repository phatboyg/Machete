namespace Machete.HL7.Tests.TestSchema
{
    public class TestLayoutMap :
        HL7LayoutMap<TestLayout, HL7Entity>
    {
        public TestLayoutMap()
        {
            Segment(x => x.MSH, 0, x => x.Required = true);
            Segment(x => x.PID, 1, x => x.Required = true);
            Layout(x => x.Orders, 2, x => x.IsRequired());
        }
    }
}