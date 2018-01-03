namespace Machete.HL7.Tests.TestSchema
{
    using HL7Schema.V26;


    public interface ORM_O01_OBSERVATION :
        HL7Layout
    {
        Segment<OBX> OBX { get; }
        SegmentList<NTE> NTE { get; }
    }
}