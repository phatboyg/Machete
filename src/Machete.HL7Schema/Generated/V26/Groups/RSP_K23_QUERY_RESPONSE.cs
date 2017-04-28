// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// RSP_K23_QUERY_RESPONSE (Group) - 
    /// </summary>
    public interface RSP_K23_QUERY_RESPONSE :
        HL7Template
    {
        /// <summary>
        /// PID
        /// </summary>
        Segment<PID> PID { get; }
    }
}