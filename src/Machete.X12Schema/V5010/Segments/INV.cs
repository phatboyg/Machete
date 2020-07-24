namespace Machete.X12Schema.V5010
{
    using X12;


    public interface INV :
        X12Segment
    {
        Value<string> Description1 { get; }
        
        Value<decimal> Percent { get; }
        
        Value<decimal> MonetaryAmount1 { get; }
        
        Value<decimal> Quantity { get; }
        
        Value<string> StateOrProvinceCode { get; }
        
        Value<string> Description2 { get; }
        
        Value<decimal> MonetaryAmount2 { get; }
    }
}