// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    /// <summary>
    /// RP (Component) - Reference Pointer
    /// </summary>
    public interface RP :
        HL7V26Component
    {
        /// <summary>
        /// RP-1  Pointer
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> Pointer { get; }

        /// <summary>
        /// RP-2  Application ID
        /// </summary>
        /// <returns>The HD value</returns>
        Value<HD> ApplicationId { get; }

        /// <summary>
        /// RP-3  Type of Data
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> TypeOfData { get; }

        /// <summary>
        /// RP-4  Subtype
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> Subtype { get; }
    }
}