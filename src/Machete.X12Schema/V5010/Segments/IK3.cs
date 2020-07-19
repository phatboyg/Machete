namespace Machete.X12Schema.V5010
{
    using X12;
    
    
    public interface IK3 :
        X12Segment
    {
        Value<string> SegmentIDCode { get; }
        
        Value<string> SegmentPosInTS { get; }
        
        Value<string> LoopIDCode { get; }
        
        Value<string> ImpleSegSynErCode { get; }
    }
}
