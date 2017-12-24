namespace Machete.HL7.Tests.TestSchema
{
    public class MacheteSample1SegmentMap :
        HL7SegmentMap<MacheteSample1Segment, HL7Segment>
    {
        public MacheteSample1SegmentMap()
        {
            Id = "MS1";

            Value(x => x.Phone, 1, x =>
            {
                x.Converter = MacheteSampleValueConverters.FormattedPhoneNumber;
                x.MaxLength = 10;
            });
        }
    }
}