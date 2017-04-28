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
        HL7Template
    {
        /// <summary>
        /// ORC
        /// </summary>
        Segment<ORC> ORC { get; }

        /// <summary>
        /// TIMING
        /// </summary>
        GroupList<RSP_Z86_TIMING> Timing { get; }

        /// <summary>
        /// ORDER_DETAIL
        /// </summary>
        Group<RSP_Z86_ORDER_DETAIL> OrderDetail { get; }

        /// <summary>
        /// ENCODED_ORDER
        /// </summary>
        Group<RSP_Z86_ENCODED_ORDER> EncodedOrder { get; }

        /// <summary>
        /// DISPENSE
        /// </summary>
        Group<RSP_Z86_DISPENSE> Dispense { get; }

        /// <summary>
        /// GIVE
        /// </summary>
        Group<RSP_Z86_GIVE> Give { get; }

        /// <summary>
        /// ADMINISTRATION
        /// </summary>
        Group<RSP_Z86_ADMINISTRATION> Administration { get; }

        /// <summary>
        /// OBSERVATION
        /// </summary>
        GroupList<RSP_Z86_OBSERVATION> Observation { get; }
    }
}