namespace Machete.HL7Schema.V26
{
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
        Value<string> Identifier { get; }

        /// <summary>
        /// CE-2  Text
        /// </summary>
        /// <returns>The DateTimeOffset value</returns>
        Value<string> Text { get; }

        /// <summary>
        /// CE-3  Name of Coding System
        /// </summary>
        /// <returns>The DateTimeOffset value</returns>
        Value<string> NameOfCodingSystem { get; }

        /// <summary>
        /// CE-4  Alternate Identifier
        /// </summary>
        /// <returns>The DateTimeOffset value</returns>
        Value<string> AlternateIdentifier { get; }

        /// <summary>
        /// CE-5  Alternate Text
        /// </summary>
        /// <returns>The DateTimeOffset value</returns>
        Value<string> AlternateText { get; }

        /// <summary>
        /// CE-6  Name of Alternate Coding System
        /// </summary>
        /// <returns>The DateTimeOffset value</returns>
        Value<string> NameOfAlternateCodingSystem { get; }
    }
}