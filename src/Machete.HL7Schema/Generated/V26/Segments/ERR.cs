// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// ERR (Segment) - Error
    /// </summary>
    public interface ERR :
        HL7Segment
    {
        /// <summary>
        /// ERR-1: Error Code and Location
        /// </summary>
        ValueList<ELD> ErrorCodeAndLocation { get; }

        /// <summary>
        /// ERR-2: Error Location
        /// </summary>
        ValueList<ERL> ErrorLocation { get; }

        /// <summary>
        /// ERR-3: HL7 Error Code
        /// </summary>
        Value<CWE> HL7ErrorCode { get; }

        /// <summary>
        /// ERR-4: Severity
        /// </summary>
        Value<string> Severity { get; }

        /// <summary>
        /// ERR-5: Application Error Code
        /// </summary>
        Value<CWE> ApplicationErrorCode { get; }

        /// <summary>
        /// ERR-6: Application Error Parameter
        /// </summary>
        Value<string> ApplicationErrorParameter { get; }

        /// <summary>
        /// ERR-7: Diagnostic Information
        /// </summary>
        Value<TX> DiagnosticInformation { get; }

        /// <summary>
        /// ERR-8: User Message
        /// </summary>
        Value<TX> UserMessage { get; }

        /// <summary>
        /// ERR-9: Inform Person Indicator
        /// </summary>
        ValueList<string> InformPersonIndicator { get; }

        /// <summary>
        /// ERR-10: Override Type
        /// </summary>
        Value<CWE> OverrideType { get; }

        /// <summary>
        /// ERR-11: Override Reason Code
        /// </summary>
        ValueList<CWE> OverrideReasonCode { get; }

        /// <summary>
        /// ERR-12: Help Desk Contact Point
        /// </summary>
        ValueList<XTN> HelpDeskContactPoint { get; }
    }
}