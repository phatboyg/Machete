// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using System;


    /// <summary>
    /// MFI (Segment) - Master File Identification
    /// </summary>
    public interface MFI :
        HL7V26Segment
    {
        /// <summary>
        /// MFI-1: Master File Identifier
        /// </summary>
        Value<CWE> MasterFileIdentifier { get; }

        /// <summary>
        /// MFI-2: Master File Application Identifier
        /// </summary>
        ValueList<HD> MasterFileApplicationIdentifier { get; }

        /// <summary>
        /// MFI-3: File-Level Event Code
        /// </summary>
        Value<string> FileLevelEventCode { get; }

        /// <summary>
        /// MFI-4: Entered Date/Time
        /// </summary>
        Value<DateTimeOffset> EnteredDateTime { get; }

        /// <summary>
        /// MFI-5: Effective Date/Time
        /// </summary>
        Value<DateTimeOffset> EffectiveDateTime { get; }

        /// <summary>
        /// MFI-6: Response Level Code
        /// </summary>
        Value<string> ResponseLevelCode { get; }
    }
}