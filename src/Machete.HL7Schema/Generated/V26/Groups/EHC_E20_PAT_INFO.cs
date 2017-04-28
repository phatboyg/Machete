// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// EHC_E20_PAT_INFO (Group) - 
    /// </summary>
    public interface EHC_E20_PAT_INFO :
        HL7Template
    {
        /// <summary>
        /// PID
        /// </summary>
        Segment<PID> PID { get; }

        /// <summary>
        /// ACC
        /// </summary>
        SegmentList<ACC> ACC { get; }

        /// <summary>
        /// INSURANCE
        /// </summary>
        GroupList<EHC_E20_INSURANCE> Insurance { get; }

        /// <summary>
        /// DIAGNOSIS
        /// </summary>
        GroupList<EHC_E20_DIAGNOSIS> Diagnosis { get; }

        /// <summary>
        /// OBX
        /// </summary>
        SegmentList<OBX> OBX { get; }
    }
}