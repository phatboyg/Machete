namespace Machete.HL7.Tests.TestSchema
{
    using System;
    using HL7Schema.V26;


    public interface MSASegment :
        HL7Segment
    {
        Value<string> AcknowledgmentCode { get; }
        Value<string> MessageControlId { get; }
        Value<string> TextMessage { get; }
        Value<decimal> ExpectedSequenceNumber { get; }
        Value<DateTimeOffset> DelayedAcknowledgmentType { get; }
        Value<CNE> ErrorCondition { get; }
        Value<decimal> MessageWaitingNumber { get; }
        Value<string> MessageWaitingPriority { get; }
    }
}