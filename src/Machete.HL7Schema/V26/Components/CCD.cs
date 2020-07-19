// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using System;


    /// <summary>
    /// CCD (Component) - Charge Code and Date
    /// </summary>
    public interface CCD :
        HL7V26Component
    {
        /// <summary>
        /// CCD-1  Invocation Event
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> WhenToChargeCode { get; }

        /// <summary>
        /// CCD-2  Date/time
        /// </summary>
        /// <returns>The DateTimeOffset value</returns>
        Value<DateTimeOffset> DateTime { get; }
    }
}