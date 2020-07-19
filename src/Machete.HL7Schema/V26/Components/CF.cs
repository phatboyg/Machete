// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// CF (Component) - Coded Element with Formatted Values
    /// </summary>
    public interface CF :
        HL7V26Component
    {
        /// <summary>
        /// CF-1  Identifier
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> Identifier { get; }

        /// <summary>
        /// CF-2  Formatted Text
        /// </summary>
        /// <returns>The FT value</returns>
        Value<FT> FormattedText { get; }

        /// <summary>
        /// CF-3  Name of Coding System
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> NameOfCodingSystem { get; }

        /// <summary>
        /// CF-4  Alternate Identifier
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> AlternateIdentifier { get; }

        /// <summary>
        /// CF-5  Alternate Formatted Text
        /// </summary>
        /// <returns>The FT value</returns>
        Value<FT> AlternateFormattedText { get; }

        /// <summary>
        /// CF-6  Name of Alternate Coding System
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> NameOfAlternateCodingSystem { get; }
    }
}