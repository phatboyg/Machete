namespace Machete.HL7.Tests.TestSchema
{
    public class EVNSegmentMap :
        HL7SegmentMap<EVNSegment, HL7Segment>
    {
        public EVNSegmentMap()
        {
            Id = "EVN";

            Name = "Event Type";

            Value(x => x.EventTypeCode, 1, x => x.MaxLength = 3);
            Value(x => x.RecordedDateTime, 2, x =>
            {
                x.Converter = HL7ValueConverters.VariableLongDateTime;
                x.Required = true;
            });
            Value(x => x.DateTimeOfPlannedEvent, 3);
            Value(x => x.EventReasonCode, 4, x => x.MaxLength(3).IsRequired());
//            Value(x => x.OperatorId, 5).MaxLength(250);
            Value(x => x.EventOccurred, 6, x => x.Converter = HL7ValueConverters.VariableLongDateTime);
            //          Value(x => x.EventFacility, 7).MaxLength(241);
        }
    }
}