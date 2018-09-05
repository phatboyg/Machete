// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using System;


    /// <summary>
    /// MSA (Segment) - Message Acknowledgment
    /// </summary>
    public interface MSA :
        HL7V26Segment
    {
        /// <summary>
        /// MSA-1: Acknowledgment Code
        /// </summary>
        Value<string> AcknowledgmentCode { get; }

        /// <summary>
        /// MSA-2: Message Control ID
        /// </summary>
        Value<string> MessageControlId { get; }

        /// <summary>
        /// MSA-3: Text Message
        /// </summary>
        Value<string> TextMessage { get; }

        /// <summary>
        /// MSA-4: Expected Sequence Number
        /// </summary>
        Value<decimal> ExpectedSequenceNumber { get; }

        /// <summary>
        /// MSA-5: Delayed Acknowledgment Type
        /// </summary>
        Value<DateTimeOffset> DelayedAcknowledgmentType { get; }

        /// <summary>
        /// MSA-6: Error Condition
        /// </summary>
        Value<CNE> ErrorCondition { get; }

        /// <summary>
        /// MSA-7: Message Waiting Number
        /// </summary>
        Value<decimal> MessageWaitingNumber { get; }

        /// <summary>
        /// MSA-8: Message Waiting Priority
        /// </summary>
        Value<string> MessageWaitingPriority { get; }
    }
}