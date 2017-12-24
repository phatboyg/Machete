namespace Machete.HL7.Tests.TestSchema
{
    public class ORCSegmentMap :
        HL7SegmentMap<ORCSegment, HL7Entity>
    {
        public ORCSegmentMap()
        {
            Id = "ORC";

            Name = "Common Order";

            Value(x => x.OrderControl, 1, x => {x.Required = true;});
            Entity(x => x.PlacerOrderNumber, 2);
            Entity(x => x.FillerOrderNumber, 3);
            Entity(x => x.PlacerGroupNumber, 4);
            Value(x => x.OrderStatus, 5);
            Value(x => x.ResponseFlag, 6);
        }
    }
}