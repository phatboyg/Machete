namespace Machete.HL7.Tests.TestSchema
{
    public class OrderLayoutMap :
        HL7LayoutMap<OrderLayout, HL7Entity>
    {
        public OrderLayoutMap()
        {
            Segment(x => x.MSH, 0, x => x.Required = true);
            Segment(x => x.PID, 1, x => x.Required = true);
            Segment(x => x.ORC, 2, x => x.Required = true);
            Segment(x => x.OBR, 3, x => x.Required = true);
            Segment(x => x.DG1, 4, x => x.Required = false);
            Segment(x => x.OBX, 5, x => x.Required = true);
            Segment(x => x.Notes, 6, x => x.Required = false);
        }
    }
}