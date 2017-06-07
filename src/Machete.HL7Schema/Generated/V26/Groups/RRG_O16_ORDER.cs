// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// RRG_O16_ORDER (Group) - 
    /// </summary>
    public interface RRG_O16_ORDER :
        HL7V26Layout
    {
        /// <summary>
        /// ORC
        /// </summary>
        Segment<ORC> ORC { get; }

        /// <summary>
        /// TIMING
        /// </summary>
        LayoutList<RRG_O16_TIMING> Timing { get; }

        /// <summary>
        /// GIVE
        /// </summary>
        Layout<RRG_O16_GIVE> Give { get; }
    }
}