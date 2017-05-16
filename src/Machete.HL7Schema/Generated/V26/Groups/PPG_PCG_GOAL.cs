// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// PPG_PCG_GOAL (Group) - 
    /// </summary>
    public interface PPG_PCG_GOAL :
        HL7Layout
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
        LayoutList<PPG_PCG_GOAL_ROLE> GoalRole { get; }

        /// <summary>
        /// GOAL_OBSERVATION
        /// </summary>
        LayoutList<PPG_PCG_GOAL_OBSERVATION> GoalObservation { get; }

        /// <summary>
        /// PROBLEM
        /// </summary>
        LayoutList<PPG_PCG_PROBLEM> Problem { get; }

        /// <summary>
        /// ORDER
        /// </summary>
        LayoutList<PPG_PCG_ORDER> Order { get; }
    }
}