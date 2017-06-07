// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// MFN_M16_STERILIZATION (Group) - 
    /// </summary>
    public interface MFN_M16_STERILIZATION :
        HL7V26Layout
    {
        /// <summary>
        /// STZ
        /// </summary>
        Segment<STZ> STZ { get; }

        /// <summary>
        /// NTE
        /// </summary>
        SegmentList<NTE> NTE { get; }
    }
}