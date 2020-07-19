// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// NMD_N02_APP_STATS (Group) - 
    /// </summary>
    public interface NMD_N02_APP_STATS :
        HL7V26Layout
    {
        /// <summary>
        /// NST
        /// </summary>
        Segment<NST> NST { get; }

        /// <summary>
        /// NTE
        /// </summary>
        SegmentList<NTE> NTE { get; }
    }
}