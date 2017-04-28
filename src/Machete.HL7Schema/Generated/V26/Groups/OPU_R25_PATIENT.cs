// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// OPU_R25_PATIENT (Group) - 
    /// </summary>
    public interface OPU_R25_PATIENT :
        HL7Template
    {
        /// <summary>
        /// PID
        /// </summary>
        Segment<PID> PID { get; }

        /// <summary>
        /// PD1
        /// </summary>
        Segment<PD1> PD1 { get; }

        /// <summary>
        /// PATIENT_OBSERVATION
        /// </summary>
        GroupList<OPU_R25_PATIENT_OBSERVATION> PatientObservation { get; }
    }
}