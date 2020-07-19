// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using System;


    /// <summary>
    /// DR (Component) - Date/Time Range
    /// </summary>
    public interface DR :
        HL7V26Component
    {
        /// <summary>
        /// DR-1  Range Start Date/Time
        /// </summary>
        /// <returns>The DateTimeOffset value</returns>
        Value<DateTimeOffset> RangeStartDateTime { get; }

        /// <summary>
        /// DR-2  Range End Date/Time
        /// </summary>
        /// <returns>The DateTimeOffset value</returns>
        Value<DateTimeOffset> RangeEndDateTime { get; }
    }
}