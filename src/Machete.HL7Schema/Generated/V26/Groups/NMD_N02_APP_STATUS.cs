// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// NMD_N02_APP_STATUS (Group) - 
    /// </summary>
    public interface NMD_N02_APP_STATUS :
        HL7Template
    {
        /// <summary>
        /// NSC
        /// </summary>
        Segment<NSC> NSC { get; }

        /// <summary>
        /// NTE
        /// </summary>
        SegmentList<NTE> NTE { get; }
    }
}