// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// REF_I12_OBSERVATION (Group) - 
    /// </summary>
    public interface REF_I12_OBSERVATION :
        HL7Template
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
        /// RESULTS_NOTES
        /// </summary>
        GroupList<REF_I12_RESULTS_NOTES> ResultNotes { get; }
    }
}