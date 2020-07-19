// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using System;


    /// <summary>
    /// CER (Segment) - Certificate Detail
    /// </summary>
    public interface CER :
        HL7V26Segment
    {
        /// <summary>
        /// CER-1: Set ID - CER
        /// </summary>
        Value<int> SetId { get; }

        /// <summary>
        /// CER-2: Serial Number
        /// </summary>
        Value<string> SerialNumber { get; }

        /// <summary>
        /// CER-3: Version
        /// </summary>
        Value<string> Version { get; }

        /// <summary>
        /// CER-4: Granting Authority
        /// </summary>
        Value<XON> GrantingAuthority { get; }

        /// <summary>
        /// CER-5: Issuing Authority
        /// </summary>
        Value<XCN> IssuingAuthority { get; }

        /// <summary>
        /// CER-6: Signature of Issuing Authority
        /// </summary>
        Value<ED> SignatureOfIssuingAuthority { get; }

        /// <summary>
        /// CER-7: Granting Country
        /// </summary>
        Value<string> GrantingCountry { get; }

        /// <summary>
        /// CER-8: Granting State/Province
        /// </summary>
        Value<CWE> GrantingStateProvince { get; }

        /// <summary>
        /// CER-9: Granting County/Parish
        /// </summary>
        Value<CWE> GrantingCountyParish { get; }

        /// <summary>
        /// CER-10: Certificate Type
        /// </summary>
        Value<CWE> CertificateType { get; }

        /// <summary>
        /// CER-11: Certificate Domain
        /// </summary>
        Value<CWE> CertificateDomain { get; }

        /// <summary>
        /// CER-12: Subject ID
        /// </summary>
        Value<string> SubjectId { get; }

        /// <summary>
        /// CER-13: Subject Name
        /// </summary>
        Value<string> SubjectName { get; }

        /// <summary>
        /// CER-14: Subject Directory Attribute Extension
        /// </summary>
        ValueList<CWE> SubjectDirectoryAttributeExtension { get; }

        /// <summary>
        /// CER-15: Subject Public Key Info
        /// </summary>
        Value<CWE> SubjectPublicKeyInfo { get; }

        /// <summary>
        /// CER-16: Authority Key Identifier
        /// </summary>
        Value<CWE> AuthorityKeyIdentifier { get; }

        /// <summary>
        /// CER-17: Basic Constraint
        /// </summary>
        Value<string> BasicConstraint { get; }

        /// <summary>
        /// CER-18: CRL Distribution Point
        /// </summary>
        ValueList<CWE> CRLDistributionPoint { get; }

        /// <summary>
        /// CER-19: Jurisdiction Country
        /// </summary>
        Value<string> JurisdictionCountry { get; }

        /// <summary>
        /// CER-20: Jurisdiction State/Province
        /// </summary>
        Value<CWE> JurisdictionStateProvince { get; }

        /// <summary>
        /// CER-21: Jurisdiction County/Parish
        /// </summary>
        Value<CWE> JurisdictionCountyParish { get; }

        /// <summary>
        /// CER-22: Jurisdiction Breadth
        /// </summary>
        ValueList<CWE> JurisdictionBreadth { get; }

        /// <summary>
        /// CER-23: Granting Date
        /// </summary>
        Value<DateTimeOffset> GrantingDate { get; }

        /// <summary>
        /// CER-24: Issuing Date
        /// </summary>
        Value<DateTimeOffset> IssuingDate { get; }

        /// <summary>
        /// CER-25: Activation Date
        /// </summary>
        Value<DateTimeOffset> ActivationDate { get; }

        /// <summary>
        /// CER-26: Inactivation Date
        /// </summary>
        Value<DateTimeOffset> InactivationDate { get; }

        /// <summary>
        /// CER-27: Expiration Date
        /// </summary>
        Value<DateTimeOffset> ExpirationDate { get; }

        /// <summary>
        /// CER-28: Renewal Date
        /// </summary>
        Value<DateTimeOffset> RenewalDate { get; }

        /// <summary>
        /// CER-29: Revocation Date
        /// </summary>
        Value<DateTimeOffset> RevocationDate { get; }

        /// <summary>
        /// CER-30: Revocation Reason Code
        /// </summary>
        Value<CWE> RevocationReasonCode { get; }

        /// <summary>
        /// CER-31: Certificate Status Code
        /// </summary>
        Value<CWE> CertificateStatusCode { get; }
    }
}