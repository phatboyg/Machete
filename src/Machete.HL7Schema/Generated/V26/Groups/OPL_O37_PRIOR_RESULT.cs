// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// OPL_O37_PRIOR_RESULT (Group) - 
    /// </summary>
    public interface OPL_O37_PRIOR_RESULT :
        HL7Template
    {
        /// <summary>
        /// NK1
        /// </summary>
        SegmentList<NK1> NK1 { get; }

        /// <summary>
        /// PATIENT_PRIOR
        /// </summary>
        Group<OPL_O37_PATIENT_PRIOR> PatientPrior { get; }

        /// <summary>
        /// PATIENT_VISIT_PRIOR
        /// </summary>
        Group<OPL_O37_PATIENT_VISIT_PRIOR> PatientVisitPrior { get; }

        /// <summary>
        /// AL1
        /// </summary>
        Segment<AL1> AL1 { get; }

        /// <summary>
        /// ORDER_PRIOR
        /// </summary>
        GroupList<OPL_O37_ORDER_PRIOR> OrderPrior { get; }
    }
}