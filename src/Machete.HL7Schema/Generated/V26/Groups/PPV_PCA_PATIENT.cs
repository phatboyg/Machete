// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// PPV_PCA_PATIENT (Group) - 
    /// </summary>
    public interface PPV_PCA_PATIENT :
        HL7Layout
    {
        /// <summary>
        /// PID
        /// </summary>
        Segment<PID> PID { get; }

        /// <summary>
        /// PATIENT_VISIT
        /// </summary>
        Layout<PPV_PCA_PATIENT_VISIT> PatientVisit { get; }

        /// <summary>
        /// GOAL
        /// </summary>
        LayoutList<PPV_PCA_GOAL> Goal { get; }
    }
}