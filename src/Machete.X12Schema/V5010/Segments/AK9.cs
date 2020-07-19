namespace Machete.X12Schema.V5010
{
    using X12;
    
    
    public interface AK9 :
        X12Segment
    {
        Value<string> FunctGroupAckCode { get; }
        
        Value<string> NumberOfTSIncluded { get; }
        
        Value<string> NumberOfReceivedTS { get; }
        
        Value<string> NumberOfAcceptedTS { get; }
        
        Value<string> FunctGroupErrorCode1 { get; }
        
        Value<string> FunctGroupErrorCode2 { get; }
        
        Value<string> FunctGroupErrorCode3 { get; }
        
        Value<string> FunctGroupErrorCode4 { get; }
        
        Value<string> FunctGroupErrorCode5 { get; }
    }
}
