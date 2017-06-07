// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// PEX_P07_EXPERIENCE (Group) - 
    /// </summary>
    public interface PEX_P07_EXPERIENCE :
        HL7V26Layout
    {
        /// <summary>
        /// PES
        /// </summary>
        Segment<PES> PES { get; }

        /// <summary>
        /// PEX_OBSERVATION
        /// </summary>
        LayoutList<PEX_P07_PEX_OBSERVATION> PexObservation { get; }
    }
}