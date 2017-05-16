// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// MFN_M02_MF_STAFF (Group) - 
    /// </summary>
    public interface MFN_M02_MF_STAFF :
        HL7Layout
    {
        /// <summary>
        /// MFE
        /// </summary>
        Segment<MFE> MFE { get; }

        /// <summary>
        /// STF
        /// </summary>
        Segment<STF> STF { get; }

        /// <summary>
        /// PRA
        /// </summary>
        SegmentList<PRA> PRA { get; }

        /// <summary>
        /// ORG
        /// </summary>
        SegmentList<ORG> ORG { get; }

        /// <summary>
        /// AFF
        /// </summary>
        SegmentList<AFF> AFF { get; }

        /// <summary>
        /// LAN
        /// </summary>
        SegmentList<LAN> LAN { get; }

        /// <summary>
        /// EDU
        /// </summary>
        SegmentList<EDU> EDU { get; }

        /// <summary>
        /// CER
        /// </summary>
        SegmentList<CER> CER { get; }

        /// <summary>
        /// NTE
        /// </summary>
        SegmentList<NTE> NTE { get; }
    }
}