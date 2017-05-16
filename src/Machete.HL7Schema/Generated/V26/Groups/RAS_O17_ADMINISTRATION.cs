// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// RAS_O17_ADMINISTRATION (Group) - 
    /// </summary>
    public interface RAS_O17_ADMINISTRATION :
        HL7Layout
    {
        /// <summary>
        /// RXA
        /// </summary>
        SegmentList<RXA> RXA { get; }

        /// <summary>
        /// RXR
        /// </summary>
        Segment<RXR> RXR { get; }

        /// <summary>
        /// OBSERVATION
        /// </summary>
        LayoutList<RAS_O17_OBSERVATION> Observation { get; }
    }
}