// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    /// <summary>
    /// RI (Component) - Repeat Interval
    /// </summary>
    public interface RI :
        HL7V26Component
    {
        /// <summary>
        /// RI-1  Repeat Pattern
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> RepeatPattern { get; }

        /// <summary>
        /// RI-2  Explicit Time Interval
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> ExplicitTimeInterval { get; }
    }
}