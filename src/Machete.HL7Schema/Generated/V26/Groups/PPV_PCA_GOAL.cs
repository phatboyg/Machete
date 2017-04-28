// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// PPV_PCA_GOAL (Group) - 
    /// </summary>
    public interface PPV_PCA_GOAL :
        HL7Template
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
        GroupList<PPV_PCA_GOAL_ROLE> GoalRole { get; }

        /// <summary>
        /// GOAL_PATHWAY
        /// </summary>
        GroupList<PPV_PCA_GOAL_PATHWAY> GoalPathway { get; }

        /// <summary>
        /// GOAL_OBSERVATION
        /// </summary>
        GroupList<PPV_PCA_GOAL_OBSERVATION> GoalObservation { get; }

        /// <summary>
        /// PROBLEM
        /// </summary>
        GroupList<PPV_PCA_PROBLEM> Problem { get; }

        /// <summary>
        /// ORDER
        /// </summary>
        GroupList<PPV_PCA_ORDER> Order { get; }
    }
}