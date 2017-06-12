namespace Machete.HL7.Tests.Segments
{
    public interface ParserTestSegment :
        HL7Segment
    {
        Value<string> StandardText { get; }
    }
}