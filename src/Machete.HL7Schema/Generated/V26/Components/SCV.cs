// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    /// <summary>
    /// SCV (Component) - Scheduling Class Value Pair
    /// </summary>
    public interface SCV :
        HL7V26Component
    {
        /// <summary>
        /// SCV-1  Parameter Class
        /// </summary>
        /// <returns>The CWE value</returns>
        Value<CWE> ParameterClass { get; }

        /// <summary>
        /// SCV-2  Parameter Value
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> ParameterValue { get; }
    }
}