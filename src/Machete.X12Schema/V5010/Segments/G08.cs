namespace Machete.X12Schema.V5010
{
    using X12;


    public interface G08 :
        X12Segment
    {
        Value<int> QuantityOfPalletsReceived { get; }
        
        Value<int> QuantityOfPalletsReturned { get; }
        
        Value<decimal> QuantityContested { get; }
        
        Value<string> ReceivingConditionCode { get; }
    }
}