// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// OMG_O19_PRIOR_RESULT (Group) - 
    /// </summary>
    public interface OMG_O19_PRIOR_RESULT :
        HL7Template
    {
        /// <summary>
        /// PATIENT_PRIOR
        /// </summary>
        Group<OMG_O19_PATIENT_PRIOR> PatientPrior { get; }

        /// <summary>
        /// PATIENT_VISIT_PRIOR
        /// </summary>
        Group<OMG_O19_PATIENT_VISIT_PRIOR> PatientVisitPrior { get; }

        /// <summary>
        /// AL1
        /// </summary>
        SegmentList<AL1> AL1 { get; }

        /// <summary>
        /// ORDER_PRIOR
        /// </summary>
        GroupList<OMG_O19_ORDER_PRIOR> OrderPrior { get; }
    }
}