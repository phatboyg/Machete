// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using System;
    using HL7;

    /// <summary>
    /// TQ1 (Segment) - Timing/Quantity
    /// </summary>
    public interface TQ1 :
        HL7Segment
    {
        /// <summary>
        /// TQ1-1: Set ID - TQ1
        /// </summary>
        Value<int> SetId { get; }

        /// <summary>
        /// TQ1-2: Quantity
        /// </summary>
        Value<CQ> Quantity { get; }

        /// <summary>
        /// TQ1-3: Repeat Pattern
        /// </summary>
        ValueList<RPT> RepeatPattern { get; }

        /// <summary>
        /// TQ1-4: Explicit Time
        /// </summary>
        ValueList<DateTimeOffset> ExplicitTime { get; }

        /// <summary>
        /// TQ1-5: Relative Time and Units
        /// </summary>
        ValueList<CQ> RelativeTimeAndUnits { get; }

        /// <summary>
        /// TQ1-6: Service Duration
        /// </summary>
        Value<CQ> ServiceDuration { get; }

        /// <summary>
        /// TQ1-7: Start date/time
        /// </summary>
        Value<DateTimeOffset> StartDateTime { get; }

        /// <summary>
        /// TQ1-8: End date/time
        /// </summary>
        Value<DateTimeOffset> EndDateTime { get; }

        /// <summary>
        /// TQ1-9: Priority
        /// </summary>
        ValueList<CWE> Priority { get; }

        /// <summary>
        /// TQ1-10: Condition text
        /// </summary>
        Value<TX> ConditionText { get; }

        /// <summary>
        /// TQ1-11: Text instruction
        /// </summary>
        Value<TX> TextInstruction { get; }

        /// <summary>
        /// TQ1-12: Conjunction
        /// </summary>
        Value<string> Conjunction { get; }

        /// <summary>
        /// TQ1-13: Occurrence duration
        /// </summary>
        Value<CQ> OccurrenceDuration { get; }

        /// <summary>
        /// TQ1-14: Total occurrences
        /// </summary>
        Value<decimal> TotalOccurrences { get; }
    }
}