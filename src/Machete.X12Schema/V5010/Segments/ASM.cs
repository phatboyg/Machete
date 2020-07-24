namespace Machete.X12Schema.V5010
{
    using X12;


    public interface ASM :
        X12Segment
    {
        Value<decimal> Amount { get; }
        
        Value<string> PaymentMethodCode { get; }
        
        Value<string> AmountQualifierCode { get; }
    }
}