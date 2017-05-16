// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// ORL_O22_RESPONSE (Group) - 
    /// </summary>
    public interface ORL_O22_RESPONSE :
        HL7Layout
    {
        /// <summary>
        /// PID
        /// </summary>
        Segment<PID> PID { get; }

        /// <summary>
        /// ORDER
        /// </summary>
        LayoutList<ORL_O22_ORDER> Order { get; }
    }
}