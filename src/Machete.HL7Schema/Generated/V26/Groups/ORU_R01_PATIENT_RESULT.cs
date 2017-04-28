// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// ORU_R01_PATIENT_RESULT (Group) - 
    /// </summary>
    public interface ORU_R01_PATIENT_RESULT :
        HL7Template
    {
        /// <summary>
        /// PATIENT
        /// </summary>
        Group<ORU_R01_PATIENT> Patient { get; }

        /// <summary>
        /// ORDER_OBSERVATION
        /// </summary>
        GroupList<ORU_R01_ORDER_OBSERVATION> OrderObservation { get; }
    }
}