namespace Machete.X12.Tests.TestSchema
{
    public interface GESegment :
        X12Segment
    {
        Value<int> TransactionSetCount { get; }
        
        Value<int> ControlNumber { get; }
    }
}