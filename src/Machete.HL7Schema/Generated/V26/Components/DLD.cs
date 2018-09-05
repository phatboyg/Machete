// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using System;


    /// <summary>
    /// DLD (Component) - Discharge to Location and Date
    /// </summary>
    public interface DLD :
        HL7V26Component
    {
        /// <summary>
        /// DLD-1  Discharge to Location
        /// </summary>
        /// <returns>The CWE value</returns>
        Value<CWE> DischargeToLocation { get; }

        /// <summary>
        /// DLD-2  Effective Date
        /// </summary>
        /// <returns>The DateTimeOffset value</returns>
        Value<DateTimeOffset> EffectiveDate { get; }
    }
}