// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// RSP_Z86_COMMON_ORDER (Group) - 
    /// </summary>
    public interface RSP_Z86_COMMON_ORDER :
        HL7V26Layout
    {
        /// <summary>
        /// ORC
        /// </summary>
        Segment<ORC> ORC { get; }

        /// <summary>
        /// TIMING
        /// </summary>
        LayoutList<RSP_Z86_TIMING> Timing { get; }

        /// <summary>
        /// ORDER_DETAIL
        /// </summary>
        Layout<RSP_Z86_ORDER_DETAIL> OrderDetail { get; }

        /// <summary>
        /// ENCODED_ORDER
        /// </summary>
        Layout<RSP_Z86_ENCODED_ORDER> EncodedOrder { get; }

        /// <summary>
        /// DISPENSE
        /// </summary>
        Layout<RSP_Z86_DISPENSE> Dispense { get; }

        /// <summary>
        /// GIVE
        /// </summary>
        Layout<RSP_Z86_GIVE> Give { get; }

        /// <summary>
        /// ADMINISTRATION
        /// </summary>
        Layout<RSP_Z86_ADMINISTRATION> Administration { get; }

        /// <summary>
        /// OBSERVATION
        /// </summary>
        LayoutList<RSP_Z86_OBSERVATION> Observation { get; }
    }
}