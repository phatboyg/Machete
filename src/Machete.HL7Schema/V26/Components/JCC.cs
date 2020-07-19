// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// JCC (Component) - Job Code/Class
    /// </summary>
    public interface JCC :
        HL7V26Component
    {
        /// <summary>
        /// JCC-1  Job Code
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> JobCode { get; }

        /// <summary>
        /// JCC-2  Job Class
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> JobClass { get; }

        /// <summary>
        /// JCC-3  Job Description Text
        /// </summary>
        /// <returns>The TX value</returns>
        Value<TX> JobDescriptionText { get; }
    }
}