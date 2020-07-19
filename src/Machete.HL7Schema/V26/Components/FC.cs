// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using System;


    /// <summary>
    /// FC (Component) - Financial Class
    /// </summary>
    public interface FC :
        HL7V26Component
    {
        /// <summary>
        /// FC-1  Financial Class Code
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> FinancialClassCode { get; }

        /// <summary>
        /// FC-2  Effective Date
        /// </summary>
        /// <returns>The DateTimeOffset value</returns>
        Value<DateTimeOffset> EffectiveDate { get; }
    }
}