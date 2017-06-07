// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// NMD_N02_CLOCK_AND_STATS_WITH_NOTES (Group) - 
    /// </summary>
    public interface NMD_N02_CLOCK_AND_STATS_WITH_NOTES :
        HL7V26Layout
    {
        /// <summary>
        /// CLOCK
        /// </summary>
        Layout<NMD_N02_CLOCK> Clock { get; }

        /// <summary>
        /// APP_STATS
        /// </summary>
        Layout<NMD_N02_APP_STATS> AppStats { get; }

        /// <summary>
        /// APP_STATUS
        /// </summary>
        Layout<NMD_N02_APP_STATUS> AppStatus { get; }
    }
}