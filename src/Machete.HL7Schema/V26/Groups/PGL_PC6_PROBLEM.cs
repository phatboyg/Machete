// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// PGL_PC6_PROBLEM (Group) - 
    /// </summary>
    public interface PGL_PC6_PROBLEM :
        HL7V26Layout
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
        LayoutList<PGL_PC6_PROBLEM_ROLE> ProblemRole { get; }

        /// <summary>
        /// PROBLEM_OBSERVATION
        /// </summary>
        LayoutList<PGL_PC6_PROBLEM_OBSERVATION> ProblemObservation { get; }
    }
}