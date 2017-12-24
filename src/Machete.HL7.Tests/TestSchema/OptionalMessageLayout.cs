namespace Machete.HL7.Tests.TestSchema
{
    public interface OptionalMessageLayout :
        HL7Layout
    {
        Segment<EVNSegment> EVN { get; }
    }
}