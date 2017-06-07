// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// RPA_I08 (Message) - 
    /// </summary>
    public interface RPA_I08 :
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
        /// MSA
        /// </summary>
        Segment<MSA> MSA { get; }

        /// <summary>
        /// RF1
        /// </summary>
        Segment<RF1> RF1 { get; }

        /// <summary>
        /// AUTHORIZATION
        /// </summary>
        Layout<RPA_I08_AUTHORIZATION> Authorization { get; }

        /// <summary>
        /// PROVIDER
        /// </summary>
        LayoutList<RPA_I08_PROVIDER> Provider { get; }

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
        LayoutList<RPA_I08_INSURANCE> Insurance { get; }

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
        LayoutList<RPA_I08_PROCEDURE> Procedure { get; }

        /// <summary>
        /// OBSERVATION
        /// </summary>
        LayoutList<RPA_I08_OBSERVATION> Observation { get; }

        /// <summary>
        /// VISIT
        /// </summary>
        Layout<RPA_I08_VISIT> Visit { get; }

        /// <summary>
        /// NTE
        /// </summary>
        SegmentList<NTE> NTE { get; }
    }
}