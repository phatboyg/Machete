namespace Machete.X12Schema.V5010
{
    using X12;


    public interface SE :
        X12Segment
    {
        Value<int> SegmentCount { get; }
        
        Value<string> ControlNumber { get; }
    }
}