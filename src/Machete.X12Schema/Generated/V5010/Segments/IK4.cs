namespace Machete.X12Schema.V5010
{
    using X12;
    
    
    public interface IK4 :
        X12Segment
    {
        Value<string> PositionInSegment { get; }
        
        Value<string> DataElementRefNumber { get; }
        
        Value<string> ImpleDataSynErCode { get; }
        
        Value<string> CopyOfBadDataElement { get; }
    }
}
