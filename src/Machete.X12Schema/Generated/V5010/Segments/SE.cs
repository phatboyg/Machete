namespace Machete.X12.Schema.Segments
{
    public interface SE :
        X12Segment
    {
        Value<int> SegmentCount { get; }
        
        Value<string> ControlNumber { get; }
    }
}