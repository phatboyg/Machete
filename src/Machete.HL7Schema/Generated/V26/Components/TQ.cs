// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using System;
    using HL7;

    /// <summary>
    /// TQ (Component) - Timing Quantity
    /// </summary>
    public interface TQ :
        HL7V26Component
    {
        /// <summary>
        /// TQ-1  Quantity
        /// </summary>
        /// <returns>The CQ value</returns>
        Value<CQ> Quantity { get; }

        /// <summary>
        /// TQ-2  Interval
        /// </summary>
        /// <returns>The RI value</returns>
        Value<RI> Interval { get; }

        /// <summary>
        /// TQ-3  Duration
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> Duration { get; }

        /// <summary>
        /// TQ-4  Start Date/Time
        /// </summary>
        /// <returns>The DateTimeOffset value</returns>
        Value<DateTimeOffset> StartDateTime { get; }

        /// <summary>
        /// TQ-5  End Date/Time
        /// </summary>
        /// <returns>The DateTimeOffset value</returns>
        Value<DateTimeOffset> EndDateTime { get; }

        /// <summary>
        /// TQ-6  Priority
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> Priority { get; }

        /// <summary>
        /// TQ-7  Condition
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> Condition { get; }

        /// <summary>
        /// TQ-8  Text
        /// </summary>
        /// <returns>The TX value</returns>
        Value<TX> Text { get; }

        /// <summary>
        /// TQ-9  Conjunction
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> Conjunction { get; }

        /// <summary>
        /// TQ-10  Order Sequencing
        /// </summary>
        /// <returns>The OSD value</returns>
        Value<OSD> OrderSequencing { get; }

        /// <summary>
        /// TQ-11  Occurrence Duration
        /// </summary>
        /// <returns>The CWE value</returns>
        Value<CWE> OccurrenceDuration { get; }

        /// <summary>
        /// TQ-12  Total Occurrences
        /// </summary>
        /// <returns>The decimal value</returns>
        Value<decimal> TotalOccurrences { get; }
    }
}