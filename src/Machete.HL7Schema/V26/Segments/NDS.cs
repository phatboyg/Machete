// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using System;


    /// <summary>
    /// NDS (Segment) - Notification Detail
    /// </summary>
    public interface NDS :
        HL7V26Segment
    {
        /// <summary>
        /// NDS-1: Notification Reference Number
        /// </summary>
        Value<decimal> NotificationReferenceNumber { get; }

        /// <summary>
        /// NDS-2: Notification Date/Time
        /// </summary>
        Value<DateTimeOffset> NotificationDateTime { get; }

        /// <summary>
        /// NDS-3: Notification Alert Severity
        /// </summary>
        Value<CWE> NotificationAlertSeverity { get; }

        /// <summary>
        /// NDS-4: Notification Code
        /// </summary>
        Value<CWE> NotificationCode { get; }
    }
}