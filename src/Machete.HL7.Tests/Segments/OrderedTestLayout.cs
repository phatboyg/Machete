namespace Machete.HL7.Tests.Segments
{
    public interface OrderedTestLayout :
        HL7Layout
    {
        Segment<MSHSegment> MSH { get; }
        SegmentList<NTESegment> Notes { get; }
        LayoutList<ORCLayout> Tests { get; }
    }


    public interface ORCLayout :
        HL7Layout
    {
        Segment<ORCSegment> ORC { get; }
        LayoutList<OBRLayout> OBR { get; }
    }


    public interface OBRLayout :
        HL7Layout
    {
        Segment<OBRSegment> OBR { get; }
        Segment<DG1Segment> DG1 { get; }
        Layout<OBXLayout> OBX { get; }
    }


    public interface OBXLayout :
        HL7Layout
    {
        Segment<OBXSegment> OBX { get; }
        Segment<NTESegment> NTE { get; }
    }
}