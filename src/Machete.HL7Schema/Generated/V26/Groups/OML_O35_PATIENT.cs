// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// OML_O35_PATIENT (Group) - 
    /// </summary>
    public interface OML_O35_PATIENT :
        HL7V26Layout
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
        /// NTE
        /// </summary>
        SegmentList<NTE> NTE { get; }

        /// <summary>
        /// NK1
        /// </summary>
        SegmentList<NK1> NK1 { get; }

        /// <summary>
        /// PATIENT_VISIT
        /// </summary>
        Layout<OML_O35_PATIENT_VISIT> PatientVisit { get; }

        /// <summary>
        /// INSURANCE
        /// </summary>
        LayoutList<OML_O35_INSURANCE> Insurance { get; }

        /// <summary>
        /// GT1
        /// </summary>
        Segment<GT1> GT1 { get; }

        /// <summary>
        /// AL1
        /// </summary>
        SegmentList<AL1> AL1 { get; }
    }
}