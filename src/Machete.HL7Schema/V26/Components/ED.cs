// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// ED (Component) - Encapsulated Data
    /// </summary>
    public interface ED :
        HL7V26Component
    {
        /// <summary>
        /// ED-1  Source Application
        /// </summary>
        /// <returns>The HD value</returns>
        Value<HD> SourceApplication { get; }

        /// <summary>
        /// ED-2  Type of Data
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> TypeOfData { get; }

        /// <summary>
        /// ED-3  Data Subtype
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> DataSubtype { get; }

        /// <summary>
        /// ED-4  Encoding
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> Encoding { get; }

        /// <summary>
        /// ED-5  Data
        /// </summary>
        /// <returns>The TX value</returns>
        Value<TX> Data { get; }
    }
}