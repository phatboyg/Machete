// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// NMD_N02_CLOCK (Group) - 
    /// </summary>
    public interface NMD_N02_CLOCK :
        HL7Layout
    {
        /// <summary>
        /// NCK
        /// </summary>
        Segment<NCK> NCK { get; }

        /// <summary>
        /// NTE
        /// </summary>
        SegmentList<NTE> NTE { get; }
    }
}