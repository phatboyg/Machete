// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using System;


    /// <summary>
    /// CE (Component) - Coded Element
    /// </summary>
    public interface CE :
        HL7V26Component
    {
        /// <summary>
        /// CE-1  Identifier
        /// </summary>
        /// <returns>The DateTimeOffset value</returns>
        Value<DateTimeOffset> Identifier { get; }

        /// <summary>
        /// CE-2  Text
        /// </summary>
        /// <returns>The DateTimeOffset value</returns>
        Value<DateTimeOffset> Text { get; }

        /// <summary>
        /// CE-3  Name of Coding System
        /// </summary>
        /// <returns>The DateTimeOffset value</returns>
        Value<DateTimeOffset> NameOfCodingSystem { get; }

        /// <summary>
        /// CE-4  Alternate Identifier
        /// </summary>
        /// <returns>The DateTimeOffset value</returns>
        Value<DateTimeOffset> AlternateIdentifier { get; }

        /// <summary>
        /// CE-5  Alternate Text
        /// </summary>
        /// <returns>The DateTimeOffset value</returns>
        Value<DateTimeOffset> AlternateText { get; }

        /// <summary>
        /// CE-6  Name of Alternate Coding System
        /// </summary>
        /// <returns>The DateTimeOffset value</returns>
        Value<DateTimeOffset> NameOfAlternateCodingSystem { get; }
    }
}