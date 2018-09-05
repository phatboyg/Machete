// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using System;


    /// <summary>
    /// PLN (Component) - Practitioner License or Other ID Number
    /// </summary>
    public interface PLN :
        HL7V26Component
    {
        /// <summary>
        /// PLN-1  ID Number
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> IdNumber { get; }

        /// <summary>
        /// PLN-2  Type of ID Number
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> TypeOfIdNumber { get; }

        /// <summary>
        /// PLN-3  State/other Qualifying Information
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> StateOtherQualifyingInformation { get; }

        /// <summary>
        /// PLN-4  Expiration Date
        /// </summary>
        /// <returns>The DateTimeOffset value</returns>
        Value<DateTimeOffset> ExpirationDate { get; }
    }
}