// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using System;


    /// <summary>
    /// DLN (Component) - Driver's License Number
    /// </summary>
    public interface DLN :
        HL7V26Component
    {
        /// <summary>
        /// DLN-1  License Number
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> LicenseNumber { get; }

        /// <summary>
        /// DLN-2  Issuing State, Province, Country
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> IssuingStateProvinceCountry { get; }

        /// <summary>
        /// DLN-3  Expiration Date
        /// </summary>
        /// <returns>The DateTimeOffset value</returns>
        Value<DateTimeOffset> ExpirationDate { get; }
    }
}