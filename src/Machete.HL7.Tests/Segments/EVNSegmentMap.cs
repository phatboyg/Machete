namespace Machete.HL7.Tests.Segments
{
    public class EVNSegmentMap :
        HL7SegmentMap<EVNSegment, HL7Segment>
    {
        public EVNSegmentMap()
        {
            Id = "EVN";

            Name = "Event Type";

            Value(x => x.EventTypeCode, 1, x => x.MaxLength = 3);
            Value(x => x.RecordedDateTime, 2, x => x.LongDateTime().IsRequired());
            Value(x => x.DateTimeOfPlannedEvent, 3);
            Value(x => x.EventReasonCode, 4, x => x.MaxLength(3).IsRequired());
//            Value(x => x.OperatorId, 5).MaxLength(250);
            Value(x => x.EventOccurred, 6, x => x.LongDateTime());
            //          Value(x => x.EventFacility, 7).MaxLength(241);
        }
    }
}