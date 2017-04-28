// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// PTR_PCF_PATIENT (Group) - 
    /// </summary>
    public interface PTR_PCF_PATIENT :
        HL7Template
    {
        /// <summary>
        /// PID
        /// </summary>
        Segment<PID> PID { get; }

        /// <summary>
        /// PATIENT_VISIT
        /// </summary>
        Group<PTR_PCF_PATIENT_VISIT> PatientVisit { get; }

        /// <summary>
        /// PATHWAY
        /// </summary>
        GroupList<PTR_PCF_PATHWAY> Pathway { get; }
    }
}