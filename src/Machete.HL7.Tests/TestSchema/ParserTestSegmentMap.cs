namespace Machete.HL7.Tests.TestSchema
{
    public class ParserTestSegmentMap :
        HL7SegmentMap<ParserTestSegment, HL7Segment>
    {
        public ParserTestSegmentMap()
        {
            Id = "PTS";
            
            Value(x => x.StandardText, 1);
        }
    }
}