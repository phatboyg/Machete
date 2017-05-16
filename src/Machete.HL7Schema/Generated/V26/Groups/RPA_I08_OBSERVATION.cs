// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// RPA_I08_OBSERVATION (Group) - 
    /// </summary>
    public interface RPA_I08_OBSERVATION :
        HL7Layout
    {
        /// <summary>
        /// OBR
        /// </summary>
        Segment<OBR> OBR { get; }

        /// <summary>
        /// NTE
        /// </summary>
        SegmentList<NTE> NTE { get; }

        /// <summary>
        /// RESULTS
        /// </summary>
        LayoutList<RPA_I08_RESULTS> Results { get; }
    }
}