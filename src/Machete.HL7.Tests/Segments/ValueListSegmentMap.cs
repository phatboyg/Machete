namespace Machete.HL7.Tests.Segments
{
    public class ValueListSegmentMap :
        HL7SegmentMap<ValueListSegment, HL7Segment>
    {
        public ValueListSegmentMap()
        {
            Id = "VL1";
            
            Value(x => x.RepeatedString, 1);
        }
    }
}