namespace Machete.HL7.Tests.Segments
{
    public class OptionalMessageLayoutMap :
        HL7LayoutMap<OptionalMessageLayout, HL7Entity>
    {
        public OptionalMessageLayoutMap()
        {
            Segment(x => x.EVN, 0);
        }
    }
}