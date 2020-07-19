namespace Machete.X12Schema.V5010
{
    using X12;


    public interface AK3 :
        X12Segment
    {
        Value<string> SegmentIdCode { get; }
        
        Value<int> SegmentPositionInTransactionSet { get; }
        
        Value<string> LoopIdentifierCode { get; }
        
        Value<string> SegmentSyntaxErrorCode { get; }
    }
}