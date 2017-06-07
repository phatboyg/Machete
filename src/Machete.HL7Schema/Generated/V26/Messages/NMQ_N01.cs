// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// NMQ_N01 (Message) - 
    /// </summary>
    public interface NMQ_N01 :
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
        /// QRY_WITH_DETAIL
        /// </summary>
        Layout<NMQ_N01_QRY_WITH_DETAIL> QryWithDetail { get; }

        /// <summary>
        /// CLOCK_AND_STATISTICS
        /// </summary>
        LayoutList<NMQ_N01_CLOCK_AND_STATISTICS> ClockAndStatistics { get; }
    }
}