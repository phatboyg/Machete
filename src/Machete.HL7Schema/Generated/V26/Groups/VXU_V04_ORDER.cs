// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// VXU_V04_ORDER (Group) - 
    /// </summary>
    public interface VXU_V04_ORDER :
        HL7V26Layout
    {
        /// <summary>
        /// ORC
        /// </summary>
        Segment<ORC> ORC { get; }

        /// <summary>
        /// TIMING
        /// </summary>
        LayoutList<VXU_V04_TIMING> Timing { get; }

        /// <summary>
        /// RXA
        /// </summary>
        Segment<RXA> RXA { get; }

        /// <summary>
        /// RXR
        /// </summary>
        Segment<RXR> RXR { get; }

        /// <summary>
        /// OBSERVATION
        /// </summary>
        LayoutList<VXU_V04_OBSERVATION> Observation { get; }
    }
}