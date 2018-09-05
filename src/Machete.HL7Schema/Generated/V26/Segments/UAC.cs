// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    /// <summary>
    /// UAC (Segment) - User Authentication Credential Segment
    /// </summary>
    public interface UAC :
        HL7V26Segment
    {
        /// <summary>
        /// UAC-1: User Authentication Credential Type Code
        /// </summary>
        Value<CWE> UserAuthenticationCredentialTypeCode { get; }

        /// <summary>
        /// UAC-2: User Authentication Credential
        /// </summary>
        Value<ED> UserAuthenticationCredential { get; }
    }
}