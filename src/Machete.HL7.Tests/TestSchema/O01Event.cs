namespace Machete.HL7.Tests.TestSchema
{
    public interface O01Event :
        HL7Layout
    {
        Segment<MSHSegment> MSH { get; }
        SegmentList<NTESegment> NTE { get; }
        Segment<PIDSegment> PID { get; }
        Segment<PV1Segment> PV1 { get; }
        SegmentList<IN1Segment> Insurance { get; }
        Segment<IN1Segment> IN1 { get; }
        Segment<GT1Segment> GT1 { get; }
        SegmentList<AL1Segment> Allergies { get; }
        LayoutList<ORM_O01_ORDER> Orders { get; }
    }
}