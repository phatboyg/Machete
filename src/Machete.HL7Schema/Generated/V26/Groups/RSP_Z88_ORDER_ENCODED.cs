// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// RSP_Z88_ORDER_ENCODED (Group) - 
    /// </summary>
    public interface RSP_Z88_ORDER_ENCODED :
        HL7Template
    {
        /// <summary>
        /// RXE
        /// </summary>
        Segment<RXE> RXE { get; }

        /// <summary>
        /// TIMING_ENCODED
        /// </summary>
        GroupList<RSP_Z88_TIMING_ENCODED> TimingEncoded { get; }

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