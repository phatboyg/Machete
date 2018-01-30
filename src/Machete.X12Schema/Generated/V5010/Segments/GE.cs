namespace Machete.X12.Schema.Segments
{
    public interface GE :
        X12Segment
    {
        Value<int> TransactionSetCount { get; }
        
        Value<int> ControlNumber { get; }
    }
}