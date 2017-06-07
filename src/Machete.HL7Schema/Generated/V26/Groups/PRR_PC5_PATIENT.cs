// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// PRR_PC5_PATIENT (Group) - 
    /// </summary>
    public interface PRR_PC5_PATIENT :
        HL7V26Layout
    {
        /// <summary>
        /// PID
        /// </summary>
        Segment<PID> PID { get; }

        /// <summary>
        /// PATIENT_VISIT
        /// </summary>
        Layout<PRR_PC5_PATIENT_VISIT> PatientVisit { get; }

        /// <summary>
        /// PROBLEM
        /// </summary>
        LayoutList<PRR_PC5_PROBLEM> Problem { get; }
    }
}