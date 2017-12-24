namespace Machete.HL7.Tests.TestSchema
{
    public interface OrderLayout :
        HL7Layout
    {
        Segment<MSHSegment> MSH { get; }
        Segment<PIDSegment> PID { get; }
        Segment<ORCSegment> ORC { get; }
        Segment<OBRSegment> OBR { get; }
        Segment<DG1Segment> DG1 { get; }
        Segment<OBXSegment> OBX { get; }
        SegmentList<NTESegment> Notes { get; }
    }
}