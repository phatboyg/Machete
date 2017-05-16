// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// RRG_O16_GIVE (Group) - 
    /// </summary>
    public interface RRG_O16_GIVE :
        HL7Layout
    {
        /// <summary>
        /// RXG
        /// </summary>
        Segment<RXG> RXG { get; }

        /// <summary>
        /// TIMING_GIVE
        /// </summary>
        LayoutList<RRG_O16_TIMING_GIVE> TimingGive { get; }

        /// <summary>
        /// RXR
        /// </summary>
        SegmentList<RXR> RXR { get; }

        /// <summary>
        /// RXC
        /// </summary>
        SegmentList<RXC> RXC { get; }
    }
}