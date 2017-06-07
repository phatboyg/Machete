// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// ORM_O01_ORDER_DETAIL (Group) - 
    /// </summary>
    public interface ORM_O01_ORDER_DETAIL :
        HL7V26Layout
    {
        /// <summary>
        /// OBR
        /// </summary>
        Segment<OBR> OBR { get; }

        /// <summary>
        /// RQD
        /// </summary>
        Segment<RQD> RQD { get; }

        /// <summary>
        /// RQ1
        /// </summary>
        Segment<RQ1> RQ1 { get; }

        /// <summary>
        /// RXO
        /// </summary>
        Segment<RXO> RXO { get; }

        /// <summary>
        /// ODS
        /// </summary>
        Segment<ODS> ODS { get; }

        /// <summary>
        /// ODT
        /// </summary>
        Segment<ODT> ODT { get; }

        /// <summary>
        /// NTE
        /// </summary>
        SegmentList<NTE> NTE { get; }

        /// <summary>
        /// CTD
        /// </summary>
        Segment<CTD> CTD { get; }

        /// <summary>
        /// DG1
        /// </summary>
        SegmentList<DG1> DG1 { get; }

        /// <summary>
        /// OBSERVATION
        /// </summary>
        LayoutList<ORM_O01_OBSERVATION> Observation { get; }
    }
}