namespace Machete.HL7.Tests.Segments
{
    public class MessageLayoutMap :
        HL7LayoutMap<MessageLayout, HL7Entity>
    {
        public MessageLayoutMap()
        {
            Segment(x => x.MSH, 0, x => x.Required = true);
            Layout(x => x.Optional, 1);
        }
    }
}