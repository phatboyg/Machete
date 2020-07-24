namespace Machete.X12Schema.V5010
{
    using X12;


    public interface UIT :
        X12Segment
    {
        Value<C001> CompositeUnitOfMeasure { get; }
        
        Value<decimal> UnitPrice { get; }
        
        Value<string> BasisOfUnitPriceCode { get; }
    }
}