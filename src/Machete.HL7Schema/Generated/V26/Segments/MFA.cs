// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using System;


    /// <summary>
    /// MFA (Segment) - Master File Acknowledgment
    /// </summary>
    public interface MFA :
        HL7V26Segment
    {
        /// <summary>
        /// MFA-1: Record-Level Event Code
        /// </summary>
        Value<string> RecordLevelEventCode { get; }

        /// <summary>
        /// MFA-2: MFN Control ID
        /// </summary>
        Value<string> MFNControlId { get; }

        /// <summary>
        /// MFA-3: Event Completion Date/Time
        /// </summary>
        Value<DateTimeOffset> EventCompletionDateTime { get; }

        /// <summary>
        /// MFA-4: MFN Record Level Error Return
        /// </summary>
        Value<CWE> MFNRecordLevelErrorReturn { get; }

        /// <summary>
        /// MFA-5: Primary Key Value - MFA
        /// </summary>
        ValueList<string> PrimaryKeyValue { get; }

        /// <summary>
        /// MFA-6: Primary Key Value Type - MFA
        /// </summary>
        ValueList<string> PrimaryKeyValueType { get; }
    }
}