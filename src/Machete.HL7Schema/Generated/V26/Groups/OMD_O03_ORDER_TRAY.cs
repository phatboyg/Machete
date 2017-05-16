// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// OMD_O03_ORDER_TRAY (Group) - 
    /// </summary>
    public interface OMD_O03_ORDER_TRAY :
        HL7Layout
    {
        /// <summary>
        /// ORC
        /// </summary>
        Segment<ORC> ORC { get; }

        /// <summary>
        /// TIMING_TRAY
        /// </summary>
        LayoutList<OMD_O03_TIMING_TRAY> TimingTray { get; }

        /// <summary>
        /// ODT
        /// </summary>
        SegmentList<ODT> ODT { get; }

        /// <summary>
        /// NTE
        /// </summary>
        SegmentList<NTE> NTE { get; }
    }
}