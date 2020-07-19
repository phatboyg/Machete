// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// RGV_O15_ORDER_DETAIL (Group) - 
    /// </summary>
    public interface RGV_O15_ORDER_DETAIL :
        HL7V26Layout
    {
        /// <summary>
        /// RXO
        /// </summary>
        Segment<RXO> RXO { get; }

        /// <summary>
        /// ORDER_DETAIL_SUPPLEMENT
        /// </summary>
        Layout<RGV_O15_ORDER_DETAIL_SUPPLEMENT> OrderDetailSupplement { get; }
    }
}