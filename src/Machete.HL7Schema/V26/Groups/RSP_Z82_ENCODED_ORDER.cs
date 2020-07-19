// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// RSP_Z82_ENCODED_ORDER (Group) - 
    /// </summary>
    public interface RSP_Z82_ENCODED_ORDER :
        HL7V26Layout
    {
        /// <summary>
        /// RXE
        /// </summary>
        Segment<RXE> RXE { get; }

        /// <summary>
        /// TIMING_ENCODED
        /// </summary>
        LayoutList<RSP_Z82_TIMING_ENCODED> TimingEncoded { get; }

        /// <summary>
        /// RXR
        /// </summary>
        SegmentList<RXR> RXR { get; }

        /// <summary>
        /// RXC
        /// </summary>
        SegmentList<RXC> RXC { get; }
    }
}