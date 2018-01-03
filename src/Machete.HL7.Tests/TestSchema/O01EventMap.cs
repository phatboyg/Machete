namespace Machete.HL7.Tests.TestSchema
{
    public class O01EventMap :
        HL7LayoutMap<O01Event, HL7Entity>
    {
        public O01EventMap()
        {
            Segment(x => x.MSH, 0, x => x.IsRequired());
            Segment(x => x.NTE, 1, x => x.IsOptional());
            Segment(x => x.PID, 2, x => x.IsRequired());
            Segment(x => x.PV1, 3, x => x.IsRequired());
            Segment(x => x.Insurance, 4, x => x.IsOptional());
            Segment(x => x.GT1, 5, x => x.IsOptional());
            Segment(x => x.Allergies, 6, x => x.IsOptional());
            Layout(x => x.Orders, 7, x => x.IsRequired());
        }
    }
}