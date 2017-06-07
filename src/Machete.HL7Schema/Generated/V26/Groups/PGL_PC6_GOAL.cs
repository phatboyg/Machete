// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// PGL_PC6_GOAL (Group) - 
    /// </summary>
    public interface PGL_PC6_GOAL :
        HL7V26Layout
    {
        /// <summary>
        /// GOL
        /// </summary>
        Segment<GOL> GOL { get; }

        /// <summary>
        /// NTE
        /// </summary>
        SegmentList<NTE> NTE { get; }

        /// <summary>
        /// VAR
        /// </summary>
        SegmentList<VAR> VAR { get; }

        /// <summary>
        /// GOAL_ROLE
        /// </summary>
        LayoutList<PGL_PC6_GOAL_ROLE> GoalRole { get; }

        /// <summary>
        /// PATHWAY
        /// </summary>
        LayoutList<PGL_PC6_PATHWAY> Pathway { get; }

        /// <summary>
        /// OBSERVATION
        /// </summary>
        LayoutList<PGL_PC6_OBSERVATION> Observation { get; }

        /// <summary>
        /// PROBLEM
        /// </summary>
        LayoutList<PGL_PC6_PROBLEM> Problem { get; }

        /// <summary>
        /// ORDER
        /// </summary>
        LayoutList<PGL_PC6_ORDER> Order { get; }
    }
}