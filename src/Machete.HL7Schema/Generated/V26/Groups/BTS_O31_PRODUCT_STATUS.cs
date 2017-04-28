// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// BTS_O31_PRODUCT_STATUS (Group) - 
    /// </summary>
    public interface BTS_O31_PRODUCT_STATUS :
        HL7Template
    {
        /// <summary>
        /// BTX
        /// </summary>
        Segment<BTX> BTX { get; }

        /// <summary>
        /// NTE
        /// </summary>
        SegmentList<NTE> NTE { get; }
    }
}