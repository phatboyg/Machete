// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using System;


    /// <summary>
    /// PIP (Component) - Practitioner Institutional Privileges
    /// </summary>
    public interface PIP :
        HL7V26Component
    {
        /// <summary>
        /// PIP-1  Privilege
        /// </summary>
        /// <returns>The CWE value</returns>
        Value<CWE> Privilege { get; }

        /// <summary>
        /// PIP-2  Privilege Class
        /// </summary>
        /// <returns>The CWE value</returns>
        Value<CWE> PrivilegeClass { get; }

        /// <summary>
        /// PIP-3  Expiration Date
        /// </summary>
        /// <returns>The DateTimeOffset value</returns>
        Value<DateTimeOffset> ExpirationDate { get; }

        /// <summary>
        /// PIP-4  Activation Date
        /// </summary>
        /// <returns>The DateTimeOffset value</returns>
        Value<DateTimeOffset> ActivationDate { get; }

        /// <summary>
        /// PIP-5  Facility
        /// </summary>
        /// <returns>The EI value</returns>
        Value<EI> Facility { get; }
    }
}