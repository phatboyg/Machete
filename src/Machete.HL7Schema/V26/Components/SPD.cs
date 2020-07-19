// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using System;


    /// <summary>
    /// SPD (Component) - Specialty Description
    /// </summary>
    public interface SPD :
        HL7V26Component
    {
        /// <summary>
        /// SPD-1  Specialty Name
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> SpecialtyName { get; }

        /// <summary>
        /// SPD-2  Governing Board
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> GoverningBoard { get; }

        /// <summary>
        /// SPD-3  Eligible or Certified
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> EligibleOrCertified { get; }

        /// <summary>
        /// SPD-4  Date of Certification
        /// </summary>
        /// <returns>The DateTimeOffset value</returns>
        Value<DateTimeOffset> DateOfCertification { get; }
    }
}