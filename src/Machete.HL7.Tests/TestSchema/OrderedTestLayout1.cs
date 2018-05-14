namespace Machete.HL7.Tests.TestSchema
{
    public interface OrderedTestLayout1 :
        HL7Layout
    {
        Segment<ORCSegment> ORC { get; }
        Segment<OBRSegment> OBR { get; }
    }
}