namespace Machete.HL7.Tests.Segments
{
    using System;

    public interface EVNSegment :
        HL7Segment
    {
        Value<string> EventTypeCode { get; }
        Value<DateTimeOffset> RecordedDateTime { get; }
        Value<DateTimeOffset> DateTimeOfPlannedEvent { get; }

        Value<string> EventReasonCode { get; }

        //ValueList<XCN> OperatorId { get; }
        Value<DateTimeOffset> EventOccurred { get; }

        //Value<HD> EventFacility { get; }
    }
}