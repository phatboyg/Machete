// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// NMR_N01_CLOCK_AND_STATS_WITH_NOTES_ALT (Group) - 
    /// </summary>
    public interface NMR_N01_CLOCK_AND_STATS_WITH_NOTES_ALT :
        HL7Template
    {
        /// <summary>
        /// NCK
        /// </summary>
        Segment<NCK> NCK { get; }

        /// <summary>
        /// NTE
        /// </summary>
        SegmentList<NTE> NTE { get; }

        /// <summary>
        /// NST
        /// </summary>
        Segment<NST> NST { get; }

        /// <summary>
        /// NTE2
        /// </summary>
        SegmentList<NTE> NTE2 { get; }

        /// <summary>
        /// NSC
        /// </summary>
        Segment<NSC> NSC { get; }

        /// <summary>
        /// NTE3
        /// </summary>
        SegmentList<NTE> NTE3 { get; }
    }
}