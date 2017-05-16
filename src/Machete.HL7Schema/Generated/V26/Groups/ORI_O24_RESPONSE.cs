// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// ORI_O24_RESPONSE (Group) - 
    /// </summary>
    public interface ORI_O24_RESPONSE :
        HL7Layout
    {
        /// <summary>
        /// PATIENT
        /// </summary>
        Layout<ORI_O24_PATIENT> Patient { get; }

        /// <summary>
        /// ORDER
        /// </summary>
        LayoutList<ORI_O24_ORDER> Order { get; }
    }
}