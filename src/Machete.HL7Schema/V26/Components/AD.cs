// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    /// <summary>
    /// AD (Component) - Address
    /// </summary>
    public interface AD :
        HL7V26Component
    {
        /// <summary>
        /// AD-1  Street Address
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> StreetAddress { get; }

        /// <summary>
        /// AD-2  Other Designation
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> OtherDesignation { get; }

        /// <summary>
        /// AD-3  City
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> City { get; }

        /// <summary>
        /// AD-4  State or Province
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> StateOrProvince { get; }

        /// <summary>
        /// AD-5  Zip or Postal Code
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> ZipOrPostalCode { get; }

        /// <summary>
        /// AD-6  Country
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> Country { get; }

        /// <summary>
        /// AD-7  Address Type
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> AddressType { get; }

        /// <summary>
        /// AD-8  Other Geographic Designation
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> OtherGeographicDesignation { get; }
    }
}