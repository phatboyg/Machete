namespace Machete.HL7.Tests.TestSchema
{
    public interface ValueListSegment :
        HL7Segment
    {
        ValueList<string> RepeatedString { get; }
        ValueList<CXComponent> RepeatedComplexType { get; }
    }
}