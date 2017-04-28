// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// PRR_PC5_PROBLEM (Group) - 
    /// </summary>
    public interface PRR_PC5_PROBLEM :
        HL7Template
    {
        /// <summary>
        /// PRB
        /// </summary>
        Segment<PRB> PRB { get; }

        /// <summary>
        /// NTE
        /// </summary>
        SegmentList<NTE> NTE { get; }

        /// <summary>
        /// VAR
        /// </summary>
        SegmentList<VAR> VAR { get; }

        /// <summary>
        /// PROBLEM_ROLE
        /// </summary>
        GroupList<PRR_PC5_PROBLEM_ROLE> ProblemRole { get; }

        /// <summary>
        /// PROBLEM_PATHWAY
        /// </summary>
        GroupList<PRR_PC5_PROBLEM_PATHWAY> ProblemPathway { get; }

        /// <summary>
        /// PROBLEM_OBSERVATION
        /// </summary>
        GroupList<PRR_PC5_PROBLEM_OBSERVATION> ProblemObservation { get; }

        /// <summary>
        /// GOAL
        /// </summary>
        GroupList<PRR_PC5_GOAL> Goal { get; }

        /// <summary>
        /// ORDER
        /// </summary>
        GroupList<PRR_PC5_ORDER> Order { get; }
    }
}