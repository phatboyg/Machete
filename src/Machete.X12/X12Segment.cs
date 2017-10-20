namespace Machete.X12
{
    public interface X12Segment :
        X12Entity
    {
        Value<string> SegmentId { get; }
        Value<bool> IsEmpty { get; }
        ValueList<string> Fields { get; }
    }
}