// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using System;


    /// <summary>
    /// DIN (Component) - Date and Institution Name
    /// </summary>
    public interface DIN :
        HL7V26Component
    {
        /// <summary>
        /// DIN-1  Date
        /// </summary>
        /// <returns>The DateTimeOffset value</returns>
        Value<DateTimeOffset> Date { get; }

        /// <summary>
        /// DIN-2  Institution Name
        /// </summary>
        /// <returns>The CWE value</returns>
        Value<CWE> InstitutionName { get; }
    }
}