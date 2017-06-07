// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// PRR_PC5_ORDER_DETAIL (Group) - 
    /// </summary>
    public interface PRR_PC5_ORDER_DETAIL :
        HL7V26Layout
    {
        /// <summary>
        /// OBR
        /// </summary>
        Segment<OBR> OBR { get; }

        /// <summary>
        /// Hxx
        /// </summary>
        Segment<HL7V26Segment> Hxx { get; }

        /// <summary>
        /// NTE
        /// </summary>
        SegmentList<NTE> NTE { get; }

        /// <summary>
        /// VAR
        /// </summary>
        SegmentList<VAR> VAR { get; }

        /// <summary>
        /// ORDER_OBSERVATION
        /// </summary>
        LayoutList<PRR_PC5_ORDER_OBSERVATION> OrderObservation { get; }
    }
}