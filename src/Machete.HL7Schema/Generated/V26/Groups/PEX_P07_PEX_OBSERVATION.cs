// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// PEX_P07_PEX_OBSERVATION (Group) - 
    /// </summary>
    public interface PEX_P07_PEX_OBSERVATION :
        HL7Layout
    {
        /// <summary>
        /// PEO
        /// </summary>
        Segment<PEO> PEO { get; }

        /// <summary>
        /// PEX_CAUSE
        /// </summary>
        LayoutList<PEX_P07_PEX_CAUSE> PexCause { get; }
    }
}