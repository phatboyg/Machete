// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using System;


    /// <summary>
    /// XTN (Component) - Extended Telecommunication Number
    /// </summary>
    public interface XTN :
        HL7V26Component
    {
        /// <summary>
        /// XTN-1  Telephone Number
        /// </summary>
        /// <returns>The DateTimeOffset value</returns>
        Value<string> TelephoneNumber { get; }

        /// <summary>
        /// XTN-2  Telecommunication Use Code
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> TelecommunicationUseCode { get; }

        /// <summary>
        /// XTN-3  Telecommunication Equipment Type
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> TelecommunicationEquipmentType { get; }

        /// <summary>
        /// XTN-4  Communication Address
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> CommunicationAddress { get; }

        /// <summary>
        /// XTN-5  Country Code
        /// </summary>
        /// <returns>The decimal value</returns>
        Value<decimal> CountryCode { get; }

        /// <summary>
        /// XTN-6  Area/City Code
        /// </summary>
        /// <returns>The decimal value</returns>
        Value<decimal> AreaCityCode { get; }

        /// <summary>
        /// XTN-7  Local Number
        /// </summary>
        /// <returns>The decimal value</returns>
        Value<decimal> LocalNumber { get; }

        /// <summary>
        /// XTN-8  Extension
        /// </summary>
        /// <returns>The decimal value</returns>
        Value<decimal> Extension { get; }

        /// <summary>
        /// XTN-9  Any Text
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> AnyText { get; }

        /// <summary>
        /// XTN-10  Extension Prefix
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> ExtensionPrefix { get; }

        /// <summary>
        /// XTN-11  Speed Dial Code
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> SpeedDialCode { get; }

        /// <summary>
        /// XTN-12  Unformatted Telephone number
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> UnformattedTelephoneNumber { get; }

        /// <summary>
        /// XTN-13  Effective Start Date
        /// </summary>
        /// <returns>The DateTimeOffset value</returns>
        Value<DateTimeOffset> EffectiveStartDate { get; }

        /// <summary>
        /// XTN-14  Expiration Date
        /// </summary>
        /// <returns>The DateTimeOffset value</returns>
        Value<DateTimeOffset> ExpirationDate { get; }

        /// <summary>
        /// XTN-15  Expiration Reason
        /// </summary>
        /// <returns>The CWE value</returns>
        Value<CWE> ExpirationReason { get; }

        /// <summary>
        /// XTN-16  Protection Code
        /// </summary>
        /// <returns>The CWE value</returns>
        Value<CWE> ProtectionCode { get; }

        /// <summary>
        /// XTN-17  Shared Telecommunication Identifier
        /// </summary>
        /// <returns>The EI value</returns>
        Value<EI> SharedTelecommunicationIdentifier { get; }

        /// <summary>
        /// XTN-18  Preference Order
        /// </summary>
        /// <returns>The decimal value</returns>
        Value<decimal> PreferenceOrder { get; }
    }
}