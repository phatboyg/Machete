// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// PEX_P07_ASSOCIATED_RX_ORDER (Group) - 
    /// </summary>
    public interface PEX_P07_ASSOCIATED_RX_ORDER :
        HL7V26Layout
    {
        /// <summary>
        /// RXE
        /// </summary>
        Segment<RXE> RXE { get; }

        /// <summary>
        /// NK1_TIMING_QTY
        /// </summary>
        LayoutList<PEX_P07_NK1_TIMING_QTY> Nk1TimingQty { get; }

        /// <summary>
        /// RXR
        /// </summary>
        SegmentList<RXR> RXR { get; }
    }
}