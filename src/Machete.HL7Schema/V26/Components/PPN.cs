// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using System;


    /// <summary>
    /// PPN (Component) - Performing Person Time Stamp
    /// </summary>
    public interface PPN :
        HL7V26Component
    {
        /// <summary>
        /// PPN-1  ID Number
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> IdNumber { get; }

        /// <summary>
        /// PPN-2  Family Name
        /// </summary>
        /// <returns>The FN value</returns>
        Value<FN> FamilyName { get; }

        /// <summary>
        /// PPN-3  Given Name
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> GivenName { get; }

        /// <summary>
        /// PPN-4  Second and Further Given Names or Initials Thereof
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> MiddleInitialOrName { get; }

        /// <summary>
        /// PPN-5  Suffix (e.g., JR or III)
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> Suffix { get; }

        /// <summary>
        /// PPN-6  Prefix (e.g., DR)
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> Prefix { get; }

        /// <summary>
        /// PPN-7  Degree (e.g., MD)
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> Degree { get; }

        /// <summary>
        /// PPN-8  Source Table
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> SourceTable { get; }

        /// <summary>
        /// PPN-9  Assigning Authority
        /// </summary>
        /// <returns>The HD value</returns>
        Value<HD> AssigningAuthority { get; }

        /// <summary>
        /// PPN-10  Name Type Code
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> NameTypeCode { get; }

        /// <summary>
        /// PPN-11  Identifier Check Digit
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> IdentifierCheckDigit { get; }

        /// <summary>
        /// PPN-12  Check Digit Scheme
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> CheckDigitScheme { get; }

        /// <summary>
        /// PPN-13  Identifier Type Code
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> IdentifierTypeCode { get; }

        /// <summary>
        /// PPN-14  Assigning Facility
        /// </summary>
        /// <returns>The HD value</returns>
        Value<HD> AssigningFacility { get; }

        /// <summary>
        /// PPN-15  Date/Time Action Performed
        /// </summary>
        /// <returns>The DateTimeOffset value</returns>
        Value<DateTimeOffset> DateTimeActionPerformed { get; }

        /// <summary>
        /// PPN-16  Name Representation Code
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> NameRepresentationCode { get; }

        /// <summary>
        /// PPN-17  Name Context
        /// </summary>
        /// <returns>The CWE value</returns>
        Value<CWE> NameContext { get; }

        /// <summary>
        /// PPN-18  Name Validity Range
        /// </summary>
        /// <returns>The DR value</returns>
        Value<DR> NameValidityRange { get; }

        /// <summary>
        /// PPN-19  Name Assembly Order
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> NameAssemblyOrder { get; }

        /// <summary>
        /// PPN-20  Effective Date
        /// </summary>
        /// <returns>The DateTimeOffset value</returns>
        Value<DateTimeOffset> EffectiveDate { get; }

        /// <summary>
        /// PPN-21  Expiration Date
        /// </summary>
        /// <returns>The DateTimeOffset value</returns>
        Value<DateTimeOffset> ExpirationDate { get; }

        /// <summary>
        /// PPN-22  Professional Suffix
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> ProfessionalSuffix { get; }

        /// <summary>
        /// PPN-23  Assigning Jurisdiction
        /// </summary>
        /// <returns>The CWE value</returns>
        Value<CWE> AssigningJurisdiction { get; }

        /// <summary>
        /// PPN-24  Assigning Agency or Department
        /// </summary>
        /// <returns>The CWE value</returns>
        Value<CWE> AssigningAgencyOrDepartment { get; }
    }
}