namespace Machete.X12Schema.V5010
{
    using X12;


    public interface PCR :
        X12Segment
    {
        Value<string> PaymentCancellationType { get; }
        
        Value<decimal> MonetaryAmount { get; }
    }
}