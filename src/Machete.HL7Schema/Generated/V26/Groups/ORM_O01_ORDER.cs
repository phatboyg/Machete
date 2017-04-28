// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// ORM_O01_ORDER (Group) - 
    /// </summary>
    public interface ORM_O01_ORDER :
        HL7Template
    {
        /// <summary>
        /// ORC
        /// </summary>
        Segment<ORC> ORC { get; }

        /// <summary>
        /// ORDER_DETAIL
        /// </summary>
        Group<ORM_O01_ORDER_DETAIL> OrderDetail { get; }

        /// <summary>
        /// FT1
        /// </summary>
        SegmentList<FT1> FT1 { get; }

        /// <summary>
        /// CTI
        /// </summary>
        SegmentList<CTI> CTI { get; }

        /// <summary>
        /// BLG
        /// </summary>
        Segment<BLG> BLG { get; }
    }
}