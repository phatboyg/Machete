// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// PEX_P07_PEX_CAUSE (Group) - 
    /// </summary>
    public interface PEX_P07_PEX_CAUSE :
        HL7Layout
    {
        /// <summary>
        /// PCR
        /// </summary>
        Segment<PCR> PCR { get; }

        /// <summary>
        /// RX_ORDER
        /// </summary>
        Layout<PEX_P07_RX_ORDER> RxOrder { get; }

        /// <summary>
        /// RX_ADMINISTRATION
        /// </summary>
        LayoutList<PEX_P07_RX_ADMINISTRATION> RxAdministration { get; }

        /// <summary>
        /// PRB
        /// </summary>
        SegmentList<PRB> PRB { get; }

        /// <summary>
        /// OBX
        /// </summary>
        SegmentList<OBX> OBX { get; }

        /// <summary>
        /// NTE
        /// </summary>
        SegmentList<NTE> NTE { get; }

        /// <summary>
        /// ASSOCIATED_PERSON
        /// </summary>
        Layout<PEX_P07_ASSOCIATED_PERSON> AssociatedPerson { get; }

        /// <summary>
        /// STUDY
        /// </summary>
        LayoutList<PEX_P07_STUDY> Study { get; }
    }
}