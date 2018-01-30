namespace Machete.X12Schema.V5010
{
    using X12;
    
    
    public interface IK5 :
        X12Segment
    {
        Value<string> TSAckCode { get; }
        
        Value<string> ImpleTSSynErCode1 { get; }
        
        Value<string> ImpleTSSynErCode2 { get; }
        
        Value<string> ImpleTSSynErCode3 { get; }
        
        Value<string> ImpleTSSynErCode4 { get; }
        
        Value<string> ImpleTSSynErCode5 { get; }
    }
}
