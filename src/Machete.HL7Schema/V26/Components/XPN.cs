// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using System;


    /// <summary>
    /// XPN (Component) - Extended Person Name
    /// </summary>
    public interface XPN :
        HL7V26Component
    {
        /// <summary>
        /// XPN-1  Family Name
        /// </summary>
        /// <returns>The FN value</returns>
        Value<FN> FamilyName { get; }

        /// <summary>
        /// XPN-2  Given Name
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> GivenName { get; }

        /// <summary>
        /// XPN-3  Second and Further Given Names or Initials Thereof
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> SecondAndFurtherGivenNamesOrInitialsThereof { get; }

        /// <summary>
        /// XPN-4  Suffix (e.g., JR or III)
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> Suffix { get; }

        /// <summary>
        /// XPN-5  Prefix (e.g., DR)
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> Prefix { get; }

        /// <summary>
        /// XPN-6  Degree (e.g., MD)
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> Degree { get; }

        /// <summary>
        /// XPN-7  Name Type Code
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> NameTypeCode { get; }

        /// <summary>
        /// XPN-8  Name Representation Code
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> NameRepresentationCode { get; }

        /// <summary>
        /// XPN-9  Name Context
        /// </summary>
        /// <returns>The CWE value</returns>
        Value<CWE> NameContext { get; }

        /// <summary>
        /// XPN-10  Name Validity Range
        /// </summary>
        /// <returns>The DR value</returns>
        Value<DR> NameValidityRange { get; }

        /// <summary>
        /// XPN-11  Name Assembly Order
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> NameAssemblyOrder { get; }

        /// <summary>
        /// XPN-12  Effective Date
        /// </summary>
        /// <returns>The DateTimeOffset value</returns>
        Value<DateTimeOffset> EffectiveDate { get; }

        /// <summary>
        /// XPN-13  Expiration Date
        /// </summary>
        /// <returns>The DateTimeOffset value</returns>
        Value<DateTimeOffset> ExpirationDate { get; }

        /// <summary>
        /// XPN-14  Professional Suffix
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> ProfessionalSuffix { get; }
    }
}