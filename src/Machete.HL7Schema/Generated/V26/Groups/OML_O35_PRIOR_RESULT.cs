// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// OML_O35_PRIOR_RESULT (Group) - 
    /// </summary>
    public interface OML_O35_PRIOR_RESULT :
        HL7Layout
    {
        /// <summary>
        /// PATIENT_PRIOR
        /// </summary>
        Layout<OML_O35_PATIENT_PRIOR> PatientPrior { get; }

        /// <summary>
        /// PATIENT_VISIT_PRIOR
        /// </summary>
        Layout<OML_O35_PATIENT_VISIT_PRIOR> PatientVisitPrior { get; }

        /// <summary>
        /// AL1
        /// </summary>
        SegmentList<AL1> AL1 { get; }

        /// <summary>
        /// ORDER_PRIOR
        /// </summary>
        LayoutList<OML_O35_ORDER_PRIOR> OrderPrior { get; }
    }
}