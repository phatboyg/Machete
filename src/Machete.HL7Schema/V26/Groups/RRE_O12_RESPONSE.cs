// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// RRE_O12_RESPONSE (Group) - 
    /// </summary>
    public interface RRE_O12_RESPONSE :
        HL7V26Layout
    {
        /// <summary>
        /// PATIENT
        /// </summary>
        Layout<RRE_O12_PATIENT> Patient { get; }

        /// <summary>
        /// ORDER
        /// </summary>
        LayoutList<RRE_O12_ORDER> Order { get; }
    }
}