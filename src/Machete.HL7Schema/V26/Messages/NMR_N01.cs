// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// NMR_N01 (Message) - 
    /// </summary>
    public interface NMR_N01 :
        HL7V26Layout
    {
        /// <summary>
        /// MSH
        /// </summary>
        Segment<MSH> MSH { get; }

        /// <summary>
        /// SFT
        /// </summary>
        SegmentList<SFT> SFT { get; }

        /// <summary>
        /// UAC
        /// </summary>
        Segment<UAC> UAC { get; }

        /// <summary>
        /// MSA
        /// </summary>
        Segment<MSA> MSA { get; }

        /// <summary>
        /// ERR
        /// </summary>
        SegmentList<ERR> ERR { get; }

        /// <summary>
        /// QRD
        /// </summary>
        Segment<QRD> QRD { get; }

        /// <summary>
        /// CLOCK_AND_STATS_WITH_NOTES_ALT
        /// </summary>
        LayoutList<NMR_N01_CLOCK_AND_STATS_WITH_NOTES_ALT> ClockAndStatsWithNotesAlt { get; }
    }
}