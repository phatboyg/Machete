namespace Machete.X12Schema.V5010
{
    using X12;


    public interface AK4 :
        X12Segment
    {
        Value<PositionInSegment> PositionInSegment { get; }
        
        Value<int> DataElementReferenceNumber { get; }
        
        Value<int> DataElementSyntaxErrorCode { get; }
        
        Value<string> CopyOfDataElement { get; }
    }
}