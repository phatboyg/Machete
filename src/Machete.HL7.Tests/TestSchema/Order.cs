namespace Machete.HL7.Tests.TestSchema
{
    public interface Order :
        HL7Layout
    {
        Segment<ORCSegment> ORC { get; }
        SegmentList<OBRSegment> OBR { get; }
    }
}