// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using System;


    /// <summary>
    /// CNS (Segment) - Clear Notification
    /// </summary>
    public interface CNS :
        HL7V26Segment
    {
        /// <summary>
        /// CNS-1: Starting Notification Reference Number
        /// </summary>
        Value<decimal> StartingNotificationReferenceNumber { get; }

        /// <summary>
        /// CNS-2: Ending Notification Reference Number
        /// </summary>
        Value<decimal> EndingNotificationReferenceNumber { get; }

        /// <summary>
        /// CNS-3: Starting Notification Date/Time
        /// </summary>
        Value<DateTimeOffset> StartingNotificationDateTime { get; }

        /// <summary>
        /// CNS-4: Ending Notification Date/Time
        /// </summary>
        Value<DateTimeOffset> EndingNotificationDateTime { get; }

        /// <summary>
        /// CNS-5: Starting Notification Code
        /// </summary>
        Value<CWE> StartingNotificationCode { get; }

        /// <summary>
        /// CNS-6: Ending Notification Code
        /// </summary>
        Value<CWE> EndingNotificationCode { get; }
    }
}