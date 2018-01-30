namespace Machete.X12Schema.V5010
{
    using X12;
    
    
    public interface CTX :
        X12Segment
    {
        Value<string> ContextIdentificat { get; }
        
        Value<string> SegmentIDCode { get; }
        
        Value<string> SegmentPosInTS { get; }
        
        Value<string> LoopIDCode { get; }
        
        Value<string> PositionInSegment { get; }
        
        Value<string> ReferenceInSegment { get; }
    }
}
