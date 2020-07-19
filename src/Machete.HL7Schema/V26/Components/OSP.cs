// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using System;


    /// <summary>
    /// OSP (Component) - Occurrence Span Code and Date
    /// </summary>
    public interface OSP :
        HL7V26Component
    {
        /// <summary>
        /// OSP-1  Occurrence Span Code
        /// </summary>
        /// <returns>The CNE value</returns>
        Value<CNE> OccurrenceSpanCode { get; }

        /// <summary>
        /// OSP-2  Occurrence Span Start Date
        /// </summary>
        /// <returns>The DateTimeOffset value</returns>
        Value<DateTimeOffset> OccurrenceSpanStartDate { get; }

        /// <summary>
        /// OSP-3  Occurrence Span Stop Date
        /// </summary>
        /// <returns>The DateTimeOffset value</returns>
        Value<DateTimeOffset> OccurrenceSpanStopDate { get; }
    }
}