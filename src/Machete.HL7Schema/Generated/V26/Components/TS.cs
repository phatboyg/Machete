// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using System;


    /// <summary>
    /// TS (Component) - Time Stamp
    /// </summary>
    public interface TS :
        HL7V26Component
    {
        /// <summary>
        /// TS-1  Time
        /// </summary>
        /// <returns>The DateTimeOffset value</returns>
        Value<DateTimeOffset> Time { get; }

        /// <summary>
        /// TS-2  Degree of Precision
        /// </summary>
        /// <returns>The DateTimeOffset value</returns>
        Value<DateTimeOffset> DegreeOfPrecision { get; }
    }
}