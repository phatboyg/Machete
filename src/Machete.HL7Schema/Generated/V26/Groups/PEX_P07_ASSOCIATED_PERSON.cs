// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// PEX_P07_ASSOCIATED_PERSON (Group) - 
    /// </summary>
    public interface PEX_P07_ASSOCIATED_PERSON :
        HL7Layout
    {
        /// <summary>
        /// NK1
        /// </summary>
        Segment<NK1> NK1 { get; }

        /// <summary>
        /// ASSOCIATED_RX_ORDER
        /// </summary>
        Layout<PEX_P07_ASSOCIATED_RX_ORDER> AssociatedRxOrder { get; }

        /// <summary>
        /// ASSOCIATED_RX_ADMIN
        /// </summary>
        LayoutList<PEX_P07_ASSOCIATED_RX_ADMIN> AssociatedRxAdmin { get; }

        /// <summary>
        /// PRB
        /// </summary>
        SegmentList<PRB> PRB { get; }

        /// <summary>
        /// OBX
        /// </summary>
        SegmentList<OBX> OBX { get; }
    }
}