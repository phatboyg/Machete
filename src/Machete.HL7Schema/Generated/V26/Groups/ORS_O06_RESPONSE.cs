// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// ORS_O06_RESPONSE (Group) - 
    /// </summary>
    public interface ORS_O06_RESPONSE :
        HL7Template
    {
        /// <summary>
        /// PATIENT
        /// </summary>
        Group<ORS_O06_PATIENT> Patient { get; }

        /// <summary>
        /// ORDER
        /// </summary>
        GroupList<ORS_O06_ORDER> Order { get; }
    }
}