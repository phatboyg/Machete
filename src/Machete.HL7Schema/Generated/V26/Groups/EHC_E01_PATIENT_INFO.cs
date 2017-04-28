// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// EHC_E01_PATIENT_INFO (Group) - 
    /// </summary>
    public interface EHC_E01_PATIENT_INFO :
        HL7Template
    {
        /// <summary>
        /// PID
        /// </summary>
        Segment<PID> PID { get; }

        /// <summary>
        /// PV1
        /// </summary>
        Segment<PV1> PV1 { get; }

        /// <summary>
        /// PV2
        /// </summary>
        Segment<PV2> PV2 { get; }

        /// <summary>
        /// ACC
        /// </summary>
        SegmentList<ACC> ACC { get; }

        /// <summary>
        /// INSURANCE
        /// </summary>
        GroupList<EHC_E01_INSURANCE> Insurance { get; }

        /// <summary>
        /// DIAGNOSIS
        /// </summary>
        GroupList<EHC_E01_DIAGNOSIS> Diagnosis { get; }

        /// <summary>
        /// OBX
        /// </summary>
        SegmentList<OBX> OBX { get; }
    }
}