// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using System;


    /// <summary>
    /// OCD (Component) - Occurrence Code and Date
    /// </summary>
    public interface OCD :
        HL7V26Component
    {
        /// <summary>
        /// OCD-1  Occurrence Code
        /// </summary>
        /// <returns>The CNE value</returns>
        Value<CNE> OccurrenceCode { get; }

        /// <summary>
        /// OCD-2  Occurrence Date
        /// </summary>
        /// <returns>The DateTimeOffset value</returns>
        Value<DateTimeOffset> OccurrenceDate { get; }
    }
}