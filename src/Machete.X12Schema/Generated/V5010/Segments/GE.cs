namespace Machete.X12Schema.V5010
{
    using X12;


    public interface GE :
        X12Segment
    {
        Value<int> TransactionSetCount { get; }
        
        Value<int> ControlNumber { get; }
    }
}