// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// RSP_Z88_QUERY_RESPONSE (Group) - 
    /// </summary>
    public interface RSP_Z88_QUERY_RESPONSE :
        HL7V26Layout
    {
        /// <summary>
        /// PATIENT
        /// </summary>
        Layout<RSP_Z88_PATIENT> Patient { get; }

        /// <summary>
        /// COMMON_ORDER
        /// </summary>
        LayoutList<RSP_Z88_COMMON_ORDER> CommonOrder { get; }
    }
}