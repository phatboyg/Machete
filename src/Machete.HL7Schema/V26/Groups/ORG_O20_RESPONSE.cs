// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// ORG_O20_RESPONSE (Group) - 
    /// </summary>
    public interface ORG_O20_RESPONSE :
        HL7V26Layout
    {
        /// <summary>
        /// PATIENT
        /// </summary>
        Layout<ORG_O20_PATIENT> Patient { get; }

        /// <summary>
        /// ORDER
        /// </summary>
        LayoutList<ORG_O20_ORDER> Order { get; }
    }
}