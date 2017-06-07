// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// PEX_P07_STUDY (Group) - 
    /// </summary>
    public interface PEX_P07_STUDY :
        HL7V26Layout
    {
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