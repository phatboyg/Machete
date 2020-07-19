// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using System;


    /// <summary>
    /// CSP (Segment) - Clinical Study Phase
    /// </summary>
    public interface CSP :
        HL7V26Segment
    {
        /// <summary>
        /// CSP-1: Study Phase Identifier
        /// </summary>
        Value<CWE> StudyPhaseIdentifier { get; }

        /// <summary>
        /// CSP-2: Date/time Study Phase Began
        /// </summary>
        Value<DateTimeOffset> DateTimeStudyPhaseBegan { get; }

        /// <summary>
        /// CSP-3: Date/time Study Phase Ended
        /// </summary>
        Value<DateTimeOffset> DateTimeStudyPhaseEnded { get; }

        /// <summary>
        /// CSP-4: Study Phase Evaluability
        /// </summary>
        Value<CWE> StudyPhaseEvaluability { get; }
    }
}