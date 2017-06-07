// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// OML_O21_OBSERVATION_REQUEST (Group) - 
    /// </summary>
    public interface OML_O21_OBSERVATION_REQUEST :
        HL7V26Layout
    {
        /// <summary>
        /// OBR
        /// </summary>
        Segment<OBR> OBR { get; }

        /// <summary>
        /// TCD
        /// </summary>
        Segment<TCD> TCD { get; }

        /// <summary>
        /// NTE
        /// </summary>
        SegmentList<NTE> NTE { get; }

        /// <summary>
        /// ROL
        /// </summary>
        SegmentList<ROL> ROL { get; }

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
        LayoutList<OML_O21_OBSERVATION> Observation { get; }

        /// <summary>
        /// SPECIMEN
        /// </summary>
        LayoutList<OML_O21_SPECIMEN> Specimen { get; }

        /// <summary>
        /// PRIOR_RESULT
        /// </summary>
        LayoutList<OML_O21_PRIOR_RESULT> PriorResult { get; }
    }
}