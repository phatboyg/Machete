namespace Machete.HL7.Tests.TestSchema
{
    public class WillNeverMatchLayoutMap :
        HL7LayoutMap<WillNeverMatchLayout, HL7Entity>
    {
        public WillNeverMatchLayoutMap()
        {
            Segment(x => x.MSH, 0, x => x.IsRequired());
            Segment(x => x.MTS, 1, x => x.IsRequired());
            Segment(x => x.PID, 2, x => x.IsRequired());
        }
    }
}