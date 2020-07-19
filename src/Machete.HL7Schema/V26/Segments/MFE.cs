// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using System;


    /// <summary>
    /// MFE (Segment) - Master File Entry
    /// </summary>
    public interface MFE :
        HL7V26Segment
    {
        /// <summary>
        /// MFE-1: Record-Level Event Code
        /// </summary>
        Value<string> RecordLevelEventCode { get; }

        /// <summary>
        /// MFE-2: MFN Control ID
        /// </summary>
        Value<string> MFNControlId { get; }

        /// <summary>
        /// MFE-3: Effective Date/Time
        /// </summary>
        Value<DateTimeOffset> EffectiveDateTime { get; }

        /// <summary>
        /// MFE-4: Primary Key Value - MFE
        /// </summary>
        ValueList<string> PrimaryKeyValue { get; }

        /// <summary>
        /// MFE-5: Primary Key Value Type
        /// </summary>
        ValueList<string> PrimaryKeyValueType { get; }

        /// <summary>
        /// MFE-6: Entered Date/Time
        /// </summary>
        Value<DateTimeOffset> EnteredDateTime { get; }

        /// <summary>
        /// MFE-7: Entered By
        /// </summary>
        Value<XCN> EnteredBy { get; }
    }
}