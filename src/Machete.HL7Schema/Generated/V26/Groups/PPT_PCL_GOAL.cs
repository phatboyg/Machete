// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// PPT_PCL_GOAL (Group) - 
    /// </summary>
    public interface PPT_PCL_GOAL :
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
        LayoutList<PPT_PCL_GOAL_ROLE> GoalRole { get; }

        /// <summary>
        /// GOAL_OBSERVATION
        /// </summary>
        LayoutList<PPT_PCL_GOAL_OBSERVATION> GoalObservation { get; }

        /// <summary>
        /// PROBLEM
        /// </summary>
        LayoutList<PPT_PCL_PROBLEM> Problem { get; }

        /// <summary>
        /// ORDER
        /// </summary>
        LayoutList<PPT_PCL_ORDER> Order { get; }
    }
}