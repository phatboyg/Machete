// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// OML_O21_ORDER_PRIOR (Group) - 
    /// </summary>
    public interface OML_O21_ORDER_PRIOR :
        HL7V26Layout
    {
        /// <summary>
        /// ORC
        /// </summary>
        Segment<ORC> ORC { get; }

        /// <summary>
        /// OBR
        /// </summary>
        Segment<OBR> OBR { get; }

        /// <summary>
        /// NTE
        /// </summary>
        SegmentList<NTE> NTE { get; }

        /// <summary>
        /// ROL
        /// </summary>
        SegmentList<ROL> ROL { get; }

        /// <summary>
        /// TIMING_PRIOR
        /// </summary>
        LayoutList<OML_O21_TIMING_PRIOR> TimingPrior { get; }

        /// <summary>
        /// OBSERVATION_PRIOR
        /// </summary>
        LayoutList<OML_O21_OBSERVATION_PRIOR> ObservationPrior { get; }
    }
}