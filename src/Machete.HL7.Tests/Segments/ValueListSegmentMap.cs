namespace Machete.HL7.Tests.Segments
{
    public class ValueListSegmentMap :
        HL7SegmentMap<ValueListSegment, HL7Entity>
    {
        public ValueListSegmentMap()
        {
            Id = "VL1";

            Name = "Something";
            
            Value(x => x.RepeatedString, 1);
            Entity(x => x.RepeatedComplexType, 2);
        }
    }
}