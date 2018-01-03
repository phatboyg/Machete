namespace Machete.HL7.Tests.TestSchema
{
    public interface ORM_O01_ORDER_DETAIL :
        HL7Layout
    {
        Segment<OBRSegment> OBR { get; }
        SegmentList<NTESegment> NTE { get; }
        SegmentList<DG1Segment> DG1 { get; }
        LayoutList<ORM_O01_OBSERVATION> Observation { get; }
    }
}