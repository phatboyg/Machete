namespace Machete.X12Schema.V5010
{
    using X12;


    public interface AK5 :
        X12Segment
    {
        Value<string> TransactionSetAcknowledgementCode { get; }
        
        Value<string> TransactionSetSyntaxErrorCode1 { get; }
        
        Value<string> TransactionSetSyntaxErrorCode2 { get; }
        
        Value<string> TransactionSetSyntaxErrorCode3 { get; }
        
        Value<string> TransactionSetSyntaxErrorCode4 { get; }
        
        Value<string> TransactionSetSyntaxErrorCode5 { get; }
    }
}