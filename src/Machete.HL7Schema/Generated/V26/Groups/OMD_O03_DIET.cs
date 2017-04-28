// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// OMD_O03_DIET (Group) - 
    /// </summary>
    public interface OMD_O03_DIET :
        HL7Template
    {
        /// <summary>
        /// ODS
        /// </summary>
        SegmentList<ODS> ODS { get; }

        /// <summary>
        /// NTE
        /// </summary>
        SegmentList<NTE> NTE { get; }

        /// <summary>
        /// OBSERVATION
        /// </summary>
        GroupList<OMD_O03_OBSERVATION> Observation { get; }
    }
}