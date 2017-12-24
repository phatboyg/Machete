namespace Machete.HL7.Tests.TestSchema
{
    public class DateTimeSegmentMap :
        HL7SegmentMap<DateTimeSegment, HL7Segment>
    {
        public DateTimeSegmentMap()
        {
            Id = "ZHX";

            Value(x => x.TestDateTimeOffset, 1, x =>
            {
                x.Converter = HL7ValueConverters.VariableLongDateTime;
                x.MaxLength = 26;
            });
            Value(x => x.TestDateTimeOffsetWithTime, 2, x =>
            {
                x.Converter = HL7ValueConverters.VariableLongDateTime;
                x.MaxLength = 26;
            });
        }
    }
}