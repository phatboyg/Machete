// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    /// <summary>
    /// CTI (Segment) - Clinical Trial Identification
    /// </summary>
    public interface CTI :
        HL7V26Segment
    {
        /// <summary>
        /// CTI-1: Sponsor Study ID
        /// </summary>
        Value<EI> SponsorStudyId { get; }

        /// <summary>
        /// CTI-2: Study Phase Identifier
        /// </summary>
        Value<CWE> StudyPhaseIdentifier { get; }

        /// <summary>
        /// CTI-3: Study Scheduled Time Point
        /// </summary>
        Value<CWE> StudyScheduledTimePoint { get; }
    }
}