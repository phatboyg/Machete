// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    /// <summary>
    /// CM1 (Segment) - Clinical Study Phase Master
    /// </summary>
    public interface CM1 :
        HL7V26Segment
    {
        /// <summary>
        /// CM1-1: Set ID - CM1
        /// </summary>
        Value<int> SetId { get; }

        /// <summary>
        /// CM1-2: Study Phase Identifier
        /// </summary>
        Value<CWE> StudyPhaseIdentifier { get; }

        /// <summary>
        /// CM1-3: Description of Study Phase
        /// </summary>
        Value<string> DescriptionOfStudyPhase { get; }
    }
}