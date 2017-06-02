namespace Machete.HL7.Tests.Segments
{
    public interface OptionalMessageLayout :
        HL7Layout
    {
        Segment<EVNSegment> EVN { get; }
    }
}