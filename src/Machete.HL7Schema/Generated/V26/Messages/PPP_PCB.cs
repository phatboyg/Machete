// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// PPP_PCB (Message) - 
    /// </summary>
    public interface PPP_PCB :
        HL7Template
    {
        /// <summary>
        /// MSH
        /// </summary>
        Segment<MSH> MSH { get; }

        /// <summary>
        /// SFT
        /// </summary>
        SegmentList<SFT> SFT { get; }

        /// <summary>
        /// UAC
        /// </summary>
        Segment<UAC> UAC { get; }

        /// <summary>
        /// PID
        /// </summary>
        Segment<PID> PID { get; }

        /// <summary>
        /// PATIENT_VISIT
        /// </summary>
        Group<PPP_PCB_PATIENT_VISIT> PatientVisit { get; }

        /// <summary>
        /// PATHWAY
        /// </summary>
        GroupList<PPP_PCB_PATHWAY> Pathway { get; }
    }
}