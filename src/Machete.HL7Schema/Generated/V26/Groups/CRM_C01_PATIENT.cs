// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// CRM_C01_PATIENT (Group) - 
    /// </summary>
    public interface CRM_C01_PATIENT :
        HL7V26Layout
    {
        /// <summary>
        /// PID
        /// </summary>
        Segment<PID> PID { get; }

        /// <summary>
        /// PV1
        /// </summary>
        Segment<PV1> PV1 { get; }

        /// <summary>
        /// CSR
        /// </summary>
        Segment<CSR> CSR { get; }

        /// <summary>
        /// CSP
        /// </summary>
        SegmentList<CSP> CSP { get; }
    }
}