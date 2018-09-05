// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using System;


    /// <summary>
    /// NST (Segment) - Application control level statistics
    /// </summary>
    public interface NST :
        HL7V26Segment
    {
        /// <summary>
        /// NST-1: Statistics Available
        /// </summary>
        Value<string> StatisticAvailable { get; }

        /// <summary>
        /// NST-2: Source Identifier
        /// </summary>
        Value<string> SourceIdentifier { get; }

        /// <summary>
        /// NST-3: Source Type
        /// </summary>
        Value<string> SourceType { get; }

        /// <summary>
        /// NST-4: Statistics Start
        /// </summary>
        Value<DateTimeOffset> StatisticStart { get; }

        /// <summary>
        /// NST-5: Statistics End
        /// </summary>
        Value<DateTimeOffset> StatisticEnd { get; }

        /// <summary>
        /// NST-6: Receive Character Count
        /// </summary>
        Value<decimal> ReceiveCharacterCount { get; }

        /// <summary>
        /// NST-7: Send Character Count
        /// </summary>
        Value<decimal> SendCharacterCount { get; }

        /// <summary>
        /// NST-8: Messages Received
        /// </summary>
        Value<decimal> MessageReceived { get; }

        /// <summary>
        /// NST-9: Messages Sent
        /// </summary>
        Value<decimal> MessageSent { get; }

        /// <summary>
        /// NST-10: Checksum Errors Received
        /// </summary>
        Value<decimal> ChecksumErrorsReceived { get; }

        /// <summary>
        /// NST-11: Length Errors Received
        /// </summary>
        Value<decimal> LengthErrorsReceived { get; }

        /// <summary>
        /// NST-12: Other Errors Received
        /// </summary>
        Value<decimal> OtherErrorsReceived { get; }

        /// <summary>
        /// NST-13: Connect Timeouts
        /// </summary>
        Value<decimal> ConnectTimeouts { get; }

        /// <summary>
        /// NST-14: Receive Timeouts
        /// </summary>
        Value<decimal> ReceiveTimeouts { get; }

        /// <summary>
        /// NST-15: Application control-level Errors
        /// </summary>
        Value<decimal> ApplicationControlLevelErrors { get; }
    }
}