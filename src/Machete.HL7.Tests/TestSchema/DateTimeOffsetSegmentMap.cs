namespace Machete.HL7.Tests.TestSchema
{
    public class DateTimeOffsetSegmentMap :
        HL7SegmentMap<DateTimeOffsetSegment, HL7Segment>
    {
        public DateTimeOffsetSegmentMap()
        {
            Id = "ZDTO";

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