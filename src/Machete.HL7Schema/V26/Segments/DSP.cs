// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// DSP (Segment) - Display Data
    /// </summary>
    public interface DSP :
        HL7V26Segment
    {
        /// <summary>
        /// DSP-1: Set ID - DSP
        /// </summary>
        Value<int> SetId { get; }

        /// <summary>
        /// DSP-2: Display Level
        /// </summary>
        Value<int> DisplayLevel { get; }

        /// <summary>
        /// DSP-3: Data Line
        /// </summary>
        Value<TX> DataLine { get; }

        /// <summary>
        /// DSP-4: Logical Break Point
        /// </summary>
        Value<string> LogicalBreakPoint { get; }

        /// <summary>
        /// DSP-5: Result ID
        /// </summary>
        Value<TX> ResultId { get; }
    }
}