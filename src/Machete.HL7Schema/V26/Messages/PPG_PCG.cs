// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// PPG_PCG (Message) - 
    /// </summary>
    public interface PPG_PCG :
        HL7V26Layout
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
        Layout<PPG_PCG_PATIENT_VISIT> PatientVisit { get; }

        /// <summary>
        /// PATHWAY
        /// </summary>
        LayoutList<PPG_PCG_PATHWAY> Pathway { get; }
    }
}