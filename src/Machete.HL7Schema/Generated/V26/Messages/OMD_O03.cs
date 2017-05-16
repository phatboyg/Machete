// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// OMD_O03 (Message) - 
    /// </summary>
    public interface OMD_O03 :
        HL7Layout
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
        /// NTE
        /// </summary>
        SegmentList<NTE> NTE { get; }

        /// <summary>
        /// PATIENT
        /// </summary>
        Layout<OMD_O03_PATIENT> Patient { get; }

        /// <summary>
        /// ORDER_DIET
        /// </summary>
        LayoutList<OMD_O03_ORDER_DIET> OrderDiet { get; }

        /// <summary>
        /// ORDER_TRAY
        /// </summary>
        LayoutList<OMD_O03_ORDER_TRAY> OrderTray { get; }
    }
}