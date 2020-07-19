// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// OUL_R23_RESULT (Group) - 
    /// </summary>
    public interface OUL_R23_RESULT :
        HL7V26Layout
    {
        /// <summary>
        /// OBX
        /// </summary>
        Segment<OBX> OBX { get; }

        /// <summary>
        /// TCD
        /// </summary>
        Segment<TCD> TCD { get; }

        /// <summary>
        /// SID
        /// </summary>
        SegmentList<SID> SID { get; }

        /// <summary>
        /// NTE
        /// </summary>
        SegmentList<NTE> NTE { get; }
    }
}