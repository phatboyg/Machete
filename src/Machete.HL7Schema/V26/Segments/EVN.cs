// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using System;


    /// <summary>
    /// EVN (Segment) - Event Type
    /// </summary>
    public interface EVN :
        HL7V26Segment
    {
        /// <summary>
        /// EVN-1: Event Type Code
        /// </summary>
        Value<string> EventTypeCode { get; }

        /// <summary>
        /// EVN-2: Recorded Date/Time
        /// </summary>
        Value<DateTimeOffset> RecordedDateTime { get; }

        /// <summary>
        /// EVN-3: Date/Time Planned Event
        /// </summary>
        Value<DateTimeOffset> DateTimePlannedEvent { get; }

        /// <summary>
        /// EVN-4: Event Reason Code
        /// </summary>
        Value<string> EventReasonCode { get; }

        /// <summary>
        /// EVN-5: Operator ID
        /// </summary>
        ValueList<XCN> OperatorId { get; }

        /// <summary>
        /// EVN-6: Event Occurred
        /// </summary>
        Value<DateTimeOffset> EventOccurred { get; }

        /// <summary>
        /// EVN-7: Event Facility
        /// </summary>
        Value<HD> EventFacility { get; }
    }
}