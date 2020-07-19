// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using System;


    /// <summary>
    /// XCN (Component) - Extended Composite ID Number and Name for Persons
    /// </summary>
    public interface XCN :
        HL7V26Component
    {
        /// <summary>
        /// XCN-1  ID Number
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> IdNumber { get; }

        /// <summary>
        /// XCN-2  Family Name
        /// </summary>
        /// <returns>The FN value</returns>
        Value<FN> FamilyName { get; }

        /// <summary>
        /// XCN-3  Given Name
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> GivenName { get; }

        /// <summary>
        /// XCN-4  Second and Further Given Names or Initials Thereof
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> SecondAndFurtherGivenNamesOrInitialsThereof { get; }

        /// <summary>
        /// XCN-5  Suffix (e.g., JR or III)
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> Suffix { get; }

        /// <summary>
        /// XCN-6  Prefix (e.g., DR)
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> Prefix { get; }

        /// <summary>
        /// XCN-7  Degree (e.g., MD)
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> Degree { get; }

        /// <summary>
        /// XCN-8  Source Table
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> SourceTable { get; }

        /// <summary>
        /// XCN-9  Assigning Authority
        /// </summary>
        /// <returns>The HD value</returns>
        Value<HD> AssigningAuthority { get; }

        /// <summary>
        /// XCN-10  Name Type Code
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> NameTypeCode { get; }

        /// <summary>
        /// XCN-11  Identifier Check Digit
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> IdentifierCheckDigit { get; }

        /// <summary>
        /// XCN-12  Check Digit Scheme
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> CheckDigitScheme { get; }

        /// <summary>
        /// XCN-13  Identifier Type Code
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> IdentifierTypeCode { get; }

        /// <summary>
        /// XCN-14  Assigning Facility
        /// </summary>
        /// <returns>The HD value</returns>
        Value<HD> AssigningFacility { get; }

        /// <summary>
        /// XCN-15  Name Representation Code
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> NameRepresentationCode { get; }

        /// <summary>
        /// XCN-16  Name Context
        /// </summary>
        /// <returns>The CWE value</returns>
        Value<CWE> NameContext { get; }

        /// <summary>
        /// XCN-17  Name Validity Range
        /// </summary>
        /// <returns>The DR value</returns>
        Value<DR> NameValidityRange { get; }

        /// <summary>
        /// XCN-18  Name Assembly Order
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> NameAssemblyOrder { get; }

        /// <summary>
        /// XCN-19  Effective Date
        /// </summary>
        /// <returns>The DateTimeOffset value</returns>
        Value<DateTimeOffset> EffectiveDate { get; }

        /// <summary>
        /// XCN-20  Expiration Date
        /// </summary>
        /// <returns>The DateTimeOffset value</returns>
        Value<DateTimeOffset> ExpirationDate { get; }

        /// <summary>
        /// XCN-21  Professional Suffix
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> ProfessionalSuffix { get; }

        /// <summary>
        /// XCN-22  Assigning Jurisdiction
        /// </summary>
        /// <returns>The CWE value</returns>
        Value<CWE> AssigningJurisdiction { get; }

        /// <summary>
        /// XCN-23  Assigning Agency or Department
        /// </summary>
        /// <returns>The CWE value</returns>
        Value<CWE> AssigningAgencyOrDepartment { get; }
    }
}