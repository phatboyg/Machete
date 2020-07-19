// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    /// <summary>
    /// RPT (Component) - Repeat Pattern
    /// </summary>
    public interface RPT :
        HL7V26Component
    {
        /// <summary>
        /// RPT-1  Repeat Pattern Code
        /// </summary>
        /// <returns>The CWE value</returns>
        Value<CWE> RepeatPatternCode { get; }

        /// <summary>
        /// RPT-2  Calendar Alignment
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> CalendarAlignment { get; }

        /// <summary>
        /// RPT-3  Phase Range Begin Value
        /// </summary>
        /// <returns>The decimal value</returns>
        Value<decimal> PhaseRangeBeginValue { get; }

        /// <summary>
        /// RPT-4  Phase Range End Value
        /// </summary>
        /// <returns>The decimal value</returns>
        Value<decimal> PhaseRangeEndValue { get; }

        /// <summary>
        /// RPT-5  Period Quantity
        /// </summary>
        /// <returns>The decimal value</returns>
        Value<decimal> PeriodQuantity { get; }

        /// <summary>
        /// RPT-6  Period Units
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> PeriodUnits { get; }

        /// <summary>
        /// RPT-7  Institution Specified Time
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> InstitutionSpecifiedTime { get; }

        /// <summary>
        /// RPT-8  Event
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> Event { get; }

        /// <summary>
        /// RPT-9  Event Offset Quantity
        /// </summary>
        /// <returns>The decimal value</returns>
        Value<decimal> EventOffsetQuantity { get; }

        /// <summary>
        /// RPT-10  Event Offset Units
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> EventOffsetUnits { get; }

        /// <summary>
        /// RPT-11  General Timing Specification
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> GeneralTimingSpecification { get; }
    }
}