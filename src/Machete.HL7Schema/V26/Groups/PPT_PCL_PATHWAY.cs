// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// PPT_PCL_PATHWAY (Group) - 
    /// </summary>
    public interface PPT_PCL_PATHWAY :
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
        LayoutList<PPT_PCL_PATHWAY_ROLE> PathwayRole { get; }

        /// <summary>
        /// GOAL
        /// </summary>
        LayoutList<PPT_PCL_GOAL> Goal { get; }
    }
}