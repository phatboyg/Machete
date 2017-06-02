namespace Machete.HL7.Tests.Segments
{
    public interface MessageLayout :
        HL7Layout
    {
        Segment<MSHSegment> MSH { get; }
        Layout<OptionalMessageLayout> Optional { get; }
    }
}