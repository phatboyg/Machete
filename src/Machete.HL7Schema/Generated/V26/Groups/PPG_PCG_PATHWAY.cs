// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// PPG_PCG_PATHWAY (Group) - 
    /// </summary>
    public interface PPG_PCG_PATHWAY :
        HL7V26Layout
    {
        /// <summary>
        /// PTH
        /// </summary>
        Segment<PTH> PTH { get; }

        /// <summary>
        /// NTE
        /// </summary>
        SegmentList<NTE> NTE { get; }

        /// <summary>
        /// VAR
        /// </summary>
        SegmentList<VAR> VAR { get; }

        /// <summary>
        /// PATHWAY_ROLE
        /// </summary>
        LayoutList<PPG_PCG_PATHWAY_ROLE> PathwayRole { get; }

        /// <summary>
        /// GOAL
        /// </summary>
        LayoutList<PPG_PCG_GOAL> Goal { get; }
    }
}