// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using System;


    /// <summary>
    /// CX (Component) - Extended Composite ID with Check Digit
    /// </summary>
    public interface CX :
        HL7V26Component
    {
        /// <summary>
        /// CX-1  ID Number
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> IdNumber { get; }

        /// <summary>
        /// CX-2  Identifier Check Digit
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> IdentifierCheckDigit { get; }

        /// <summary>
        /// CX-3  Check Digit Scheme
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> CheckDigitScheme { get; }

        /// <summary>
        /// CX-4  Assigning Authority
        /// </summary>
        /// <returns>The HD value</returns>
        Value<HD> AssigningAuthority { get; }

        /// <summary>
        /// CX-5  Identifier Type Code
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> IdentifierTypeCode { get; }

        /// <summary>
        /// CX-6  Assigning Facility
        /// </summary>
        /// <returns>The HD value</returns>
        Value<HD> AssigningFacility { get; }

        /// <summary>
        /// CX-7  Effective Date
        /// </summary>
        /// <returns>The DateTimeOffset value</returns>
        Value<DateTimeOffset> EffectiveDate { get; }

        /// <summary>
        /// CX-8  Expiration Date
        /// </summary>
        /// <returns>The DateTimeOffset value</returns>
        Value<DateTimeOffset> ExpirationDate { get; }

        /// <summary>
        /// CX-9  Assigning Jurisdiction
        /// </summary>
        /// <returns>The CWE value</returns>
        Value<CWE> AssigningJurisdiction { get; }

        /// <summary>
        /// CX-10  Assigning Agency or Department
        /// </summary>
        /// <returns>The CWE value</returns>
        Value<CWE> AssigningAgencyOrDepartment { get; }
    }
}