// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// OMG_O19_OBSERVATION (Group) - 
    /// </summary>
    public interface OMG_O19_OBSERVATION :
        HL7Template
    {
        /// <summary>
        /// OBX
        /// </summary>
        Segment<OBX> OBX { get; }

        /// <summary>
        /// NTE
        /// </summary>
        SegmentList<NTE> NTE { get; }
    }
}