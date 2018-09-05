// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    /// <summary>
    /// CM2 (Segment) - Clinical Study Schedule Master
    /// </summary>
    public interface CM2 :
        HL7V26Segment
    {
        /// <summary>
        /// CM2-1: Set ID- CM2
        /// </summary>
        Value<int> SetId { get; }

        /// <summary>
        /// CM2-2: Scheduled Time Point
        /// </summary>
        Value<CWE> ScheduledTimePoint { get; }

        /// <summary>
        /// CM2-3: Description of Time Point
        /// </summary>
        Value<string> DescriptionOfTimePoint { get; }

        /// <summary>
        /// CM2-4: Events Scheduled This Time Point
        /// </summary>
        Value<CWE> EventScheduledThisTimePoint { get; }
    }
}