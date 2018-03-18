namespace Machete.X12.Tests.TestSchema
{
    public interface SESegment :
        X12Segment
    {
        Value<int> SegmentCount { get; }
        
        Value<string> ControlNumber { get; }
    }
}