namespace Machete.HL7.Tests.Segments
{
    public interface NTESegment :
        HL7Segment
    {
        Value<int> SetId { get; }
        Value<string> SourceOfComment { get; }
//        ValueList<FT> Comment { get; }
    }
}