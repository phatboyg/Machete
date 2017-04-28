// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// RSP_Z82_QUERY_RESPONSE (Group) - 
    /// </summary>
    public interface RSP_Z82_QUERY_RESPONSE :
        HL7Template
    {
        /// <summary>
        /// PATIENT
        /// </summary>
        Group<RSP_Z82_PATIENT> Patient { get; }

        /// <summary>
        /// COMMON_ORDER
        /// </summary>
        GroupList<RSP_Z82_COMMON_ORDER> CommonOrder { get; }
    }
}