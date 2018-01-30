namespace Machete.X12Schema.V5010
{
    using X12;
    
    
    public interface QTY :
        X12Segment
    {
        Value<string> QuantityQualifier { get; }

        Value<decimal> Quantity { get; }
    }
}