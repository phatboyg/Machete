// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// OPU_R25 (Message) - 
    /// </summary>
    public interface OPU_R25 :
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
        /// NTE
        /// </summary>
        Segment<NTE> NTE { get; }

        /// <summary>
        /// PV1
        /// </summary>
        Segment<PV1> PV1 { get; }

        /// <summary>
        /// PV2
        /// </summary>
        Segment<PV2> PV2 { get; }

        /// <summary>
        /// OBX
        /// </summary>
        SegmentList<OBX> OBX { get; }

        /// <summary>
        /// NTE2
        /// </summary>
        SegmentList<NTE> NTE2 { get; }

        /// <summary>
        /// ROL
        /// </summary>
        SegmentList<ROL> ROL { get; }

        /// <summary>
        /// ACCESSION_DETAIL
        /// </summary>
        GroupList<OPU_R25_ACCESSION_DETAIL> AccessionDetail { get; }
    }
}