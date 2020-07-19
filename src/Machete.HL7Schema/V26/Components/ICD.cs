// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using System;


    /// <summary>
    /// ICD (Component) - Insurance Certification Definition
    /// </summary>
    public interface ICD :
        HL7V26Component
    {
        /// <summary>
        /// ICD-1  Certification Patient Type
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> CertificationPatientType { get; }

        /// <summary>
        /// ICD-2  Certification Required
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> CertificationRequired { get; }

        /// <summary>
        /// ICD-3  Date/Time Certification Required
        /// </summary>
        /// <returns>The DateTimeOffset value</returns>
        Value<DateTimeOffset> DateTimeCertificationRequired { get; }
    }
}