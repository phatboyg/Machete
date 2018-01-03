namespace Machete.HL7.Tests.TestSchema
{
    public interface NTESegment :
        HL7Segment
    {
        Value<int> SetId { get; }
        Value<string> SourceOfComment { get; }
    }
}