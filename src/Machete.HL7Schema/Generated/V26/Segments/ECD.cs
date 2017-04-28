// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// ECD (Segment) - Equipment Command
    /// </summary>
    public interface ECD :
        HL7Segment
    {
        /// <summary>
        /// ECD-1: Reference Command Number
        /// </summary>
        Value<decimal> ReferenceCommandNumber { get; }

        /// <summary>
        /// ECD-2: Remote Control Command
        /// </summary>
        Value<CWE> RemoteControlCommand { get; }

        /// <summary>
        /// ECD-3: Response Required
        /// </summary>
        Value<string> ResponseRequired { get; }

        /// <summary>
        /// ECD-4: Requested Completion Time
        /// </summary>
        Value<TQ> RequestedCompletionTime { get; }

        /// <summary>
        /// ECD-5: Parameters
        /// </summary>
        ValueList<TX> Parameters { get; }
    }
}