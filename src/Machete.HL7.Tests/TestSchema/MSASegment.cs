namespace Machete.HL7.Tests.TestSchema
{
    using System;


    public interface MSASegment :
        HL7Segment
    {
        Value<string> AcknowledgmentCode { get; }
        Value<string> MessageControlId { get; }
        Value<string> TextMessage { get; }
        Value<decimal> ExpectedSequenceNumber { get; }
        Value<DateTimeOffset> DelayedAcknowledgmentType { get; }
        Value<CNEComponent> ErrorCondition { get; }
        Value<decimal> MessageWaitingNumber { get; }
        Value<string> MessageWaitingPriority { get; }
    }
}