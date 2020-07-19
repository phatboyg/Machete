// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    /// <summary>
    /// OSR_Q06_RESPONSE (Group) - 
    /// </summary>
    public interface OSR_Q06_RESPONSE :
        HL7V26Layout
    {
        /// <summary>
        /// PATIENT
        /// </summary>
        Layout<OSR_Q06_PATIENT> Patient { get; }

        /// <summary>
        /// ORDER
        /// </summary>
        LayoutList<OSR_Q06_ORDER> Order { get; }
    }
}