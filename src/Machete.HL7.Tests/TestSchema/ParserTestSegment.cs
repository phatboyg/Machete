namespace Machete.HL7.Tests.TestSchema
{
    public interface ParserTestSegment :
        HL7Segment
    {
        Value<string> StandardText { get; }
    }
}