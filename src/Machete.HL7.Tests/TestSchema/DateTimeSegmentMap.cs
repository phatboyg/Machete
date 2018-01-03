namespace Machete.HL7.Tests.TestSchema
{
    public class DateTimeSegmentMap :
        HL7SegmentMap<DateTimeSegment, HL7Segment>
    {
        public DateTimeSegmentMap()
        {
            Id = "ZDT";

            Value(x => x.TestDateTime, 1, x =>
            {
                x.Converter = HL7ValueConverters.VariableShortDateTime;
                x.MaxLength = 26;
            });
        }
    }
}