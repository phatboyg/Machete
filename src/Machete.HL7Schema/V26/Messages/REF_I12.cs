// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// REF_I12 (Message) - 
    /// </summary>
    public interface REF_I12 :
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
        /// RF1
        /// </summary>
        Segment<RF1> RF1 { get; }

        /// <summary>
        /// AUTHORIZATION_CONTACT
        /// </summary>
        Layout<REF_I12_AUTHORIZATION_CONTACT> AuthorizationContact { get; }

        /// <summary>
        /// PROVIDER_CONTACT
        /// </summary>
        LayoutList<REF_I12_PROVIDER_CONTACT> ProviderContact { get; }

        /// <summary>
        /// PID
        /// </summary>
        Segment<PID> PID { get; }

        /// <summary>
        /// NK1
        /// </summary>
        SegmentList<NK1> NK1 { get; }

        /// <summary>
        /// GT1
        /// </summary>
        SegmentList<GT1> GT1 { get; }

        /// <summary>
        /// INSURANCE
        /// </summary>
        LayoutList<REF_I12_INSURANCE> Insurance { get; }

        /// <summary>
        /// ACC
        /// </summary>
        Segment<ACC> ACC { get; }

        /// <summary>
        /// DG1
        /// </summary>
        SegmentList<DG1> DG1 { get; }

        /// <summary>
        /// DRG
        /// </summary>
        SegmentList<DRG> DRG { get; }

        /// <summary>
        /// AL1
        /// </summary>
        SegmentList<AL1> AL1 { get; }

        /// <summary>
        /// PROCEDURE
        /// </summary>
        LayoutList<REF_I12_PROCEDURE> Procedure { get; }

        /// <summary>
        /// OBSERVATION
        /// </summary>
        LayoutList<REF_I12_OBSERVATION> Observation { get; }

        /// <summary>
        /// PATIENT_VISIT
        /// </summary>
        Layout<REF_I12_PATIENT_VISIT> PatientVisit { get; }

        /// <summary>
        /// NTE
        /// </summary>
        SegmentList<NTE> NTE { get; }
    }
}