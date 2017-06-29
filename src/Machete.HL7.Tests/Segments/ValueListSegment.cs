namespace Machete.HL7.Tests.Segments
{
    public interface ValueListSegment :
        HL7Segment
    {
        ValueList<string> RepeatedString { get; }
        ValueList<CXComponent> RepeatedComplexType { get; }
    }
}