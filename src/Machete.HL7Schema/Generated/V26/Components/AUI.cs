// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using System;


    /// <summary>
    /// AUI (Component) - Authorization Information
    /// </summary>
    public interface AUI :
        HL7V26Component
    {
        /// <summary>
        /// AUI-1  Authorization Number
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> AuthorizationNumber { get; }

        /// <summary>
        /// AUI-2  Date
        /// </summary>
        /// <returns>The DateTimeOffset value</returns>
        Value<DateTimeOffset> Date { get; }

        /// <summary>
        /// AUI-3  Source
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> Source { get; }
    }
}