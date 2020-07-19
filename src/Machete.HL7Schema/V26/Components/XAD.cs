// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using System;


    /// <summary>
    /// XAD (Component) - Extended Address
    /// </summary>
    public interface XAD :
        HL7V26Component
    {
        /// <summary>
        /// XAD-1  Street Address
        /// </summary>
        /// <returns>The SAD value</returns>
        Value<SAD> StreetAddress { get; }

        /// <summary>
        /// XAD-2  Other Designation
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> OtherDesignation { get; }

        /// <summary>
        /// XAD-3  City
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> City { get; }

        /// <summary>
        /// XAD-4  State or Province
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> StateOrProvince { get; }

        /// <summary>
        /// XAD-5  Zip or Postal Code
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> ZipOrPostalCode { get; }

        /// <summary>
        /// XAD-6  Country
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> Country { get; }

        /// <summary>
        /// XAD-7  Address Type
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> AddressType { get; }

        /// <summary>
        /// XAD-8  Other Geographic Designation
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> OtherGeographicDesignation { get; }

        /// <summary>
        /// XAD-9  County/Parish Code
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> CountyParishCode { get; }

        /// <summary>
        /// XAD-10  Census Tract
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> CensusTract { get; }

        /// <summary>
        /// XAD-11  Address Representation Code
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> AddressRepresentationCode { get; }

        /// <summary>
        /// XAD-12  Address Validity Range
        /// </summary>
        /// <returns>The DR value</returns>
        Value<DR> AddressValidityRange { get; }

        /// <summary>
        /// XAD-13  Effective Date
        /// </summary>
        /// <returns>The DateTimeOffset value</returns>
        Value<DateTimeOffset> EffectiveDate { get; }

        /// <summary>
        /// XAD-14  Expiration Date
        /// </summary>
        /// <returns>The DateTimeOffset value</returns>
        Value<DateTimeOffset> ExpirationDate { get; }

        /// <summary>
        /// XAD-15  Expiration Reason
        /// </summary>
        /// <returns>The CWE value</returns>
        Value<CWE> ExpirationReason { get; }

        /// <summary>
        /// XAD-16  Temporary Indicator
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> TemporaryIndicator { get; }

        /// <summary>
        /// XAD-17  Bad Address Indicator
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> BadAddressIndicator { get; }

        /// <summary>
        /// XAD-18  Address Usage
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> AddressUsage { get; }

        /// <summary>
        /// XAD-19  Addressee
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> Addressee { get; }

        /// <summary>
        /// XAD-20  Comment
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> Comment { get; }

        /// <summary>
        /// XAD-21  Preference Order
        /// </summary>
        /// <returns>The decimal value</returns>
        Value<decimal> PreferenceOrder { get; }

        /// <summary>
        /// XAD-22  Protection Code
        /// </summary>
        /// <returns>The CWE value</returns>
        Value<CWE> ProtectionCode { get; }

        /// <summary>
        /// XAD-23  Address Identifier
        /// </summary>
        /// <returns>The EI value</returns>
        Value<EI> AddressIdentifier { get; }
    }
}