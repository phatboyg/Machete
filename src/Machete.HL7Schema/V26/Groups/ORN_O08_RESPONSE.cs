// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// ORN_O08_RESPONSE (Group) - 
    /// </summary>
    public interface ORN_O08_RESPONSE :
        HL7V26Layout
    {
        /// <summary>
        /// PATIENT
        /// </summary>
        Layout<ORN_O08_PATIENT> Patient { get; }

        /// <summary>
        /// ORDER
        /// </summary>
        LayoutList<ORN_O08_ORDER> Order { get; }
    }
}