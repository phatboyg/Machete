// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// PPT_PCL_PATIENT (Group) - 
    /// </summary>
    public interface PPT_PCL_PATIENT :
        HL7V26Layout
    {
        /// <summary>
        /// PID
        /// </summary>
        Segment<PID> PID { get; }

        /// <summary>
        /// PATIENT_VISIT
        /// </summary>
        Layout<PPT_PCL_PATIENT_VISIT> PatientVisit { get; }

        /// <summary>
        /// PATHWAY
        /// </summary>
        LayoutList<PPT_PCL_PATHWAY> Pathway { get; }
    }
}