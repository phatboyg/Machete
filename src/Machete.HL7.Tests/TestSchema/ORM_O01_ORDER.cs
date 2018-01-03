namespace Machete.HL7.Tests.TestSchema
{
    public interface ORM_O01_ORDER :
        HL7Layout
    {
        Segment<ORCSegment> ORC { get; }
        Layout<ORM_O01_ORDER_DETAIL> OrderDetail { get; }
    }
}