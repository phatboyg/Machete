// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// SQM_S25_REQUEST (Group) - 
    /// </summary>
    public interface SQM_S25_REQUEST :
        HL7V26Layout
    {
        /// <summary>
        /// ARQ
        /// </summary>
        Segment<ARQ> ARQ { get; }

        /// <summary>
        /// APR
        /// </summary>
        Segment<APR> APR { get; }

        /// <summary>
        /// PID
        /// </summary>
        Segment<PID> PID { get; }

        /// <summary>
        /// RESOURCES
        /// </summary>
        LayoutList<SQM_S25_RESOURCES> Resources { get; }
    }
}