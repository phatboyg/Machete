namespace Machete.HL7.Tests.TestSchema
{
    public interface ORCSegment :
        HL7Segment
    {
        Value<string> OrderControl { get; }
        Value<EIComponent> PlacerOrderNumber { get; }
        Value<EIComponent> FillerOrderNumber { get; }
        Value<EIComponent> PlacerGroupNumber { get; }
        Value<string> OrderStatus { get; }
        Value<string> ResponseFlag { get; }
    }
}