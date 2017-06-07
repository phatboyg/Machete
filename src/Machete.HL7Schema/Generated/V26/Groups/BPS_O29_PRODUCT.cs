// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// BPS_O29_PRODUCT (Group) - 
    /// </summary>
    public interface BPS_O29_PRODUCT :
        HL7V26Layout
    {
        /// <summary>
        /// BPX
        /// </summary>
        Segment<BPX> BPX { get; }

        /// <summary>
        /// NTE
        /// </summary>
        SegmentList<NTE> NTE { get; }
    }
}