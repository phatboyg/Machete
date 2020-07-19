// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// RSP_K25_STAFF (Group) - 
    /// </summary>
    public interface RSP_K25_STAFF :
        HL7V26Layout
    {
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
    }
}