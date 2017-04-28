// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// PTR_PCF_PROBLEM (Group) - 
    /// </summary>
    public interface PTR_PCF_PROBLEM :
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
        GroupList<PTR_PCF_PROBLEM_ROLE> ProblemRole { get; }

        /// <summary>
        /// PROBLEM_OBSERVATION
        /// </summary>
        GroupList<PTR_PCF_PROBLEM_OBSERVATION> ProblemObservation { get; }

        /// <summary>
        /// GOAL
        /// </summary>
        GroupList<PTR_PCF_GOAL> Goal { get; }

        /// <summary>
        /// ORDER
        /// </summary>
        GroupList<PTR_PCF_ORDER> Order { get; }
    }
}