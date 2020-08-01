namespace Machete.X12Schema.V5010
{
    using X12;


    public interface RPA :
        X12Segment
    {
        Value<string> RateOrValueTypeCode { get; }
        
        Value<decimal> MonetaryAmount { get; }
        
        Value<decimal> Rate { get; }
        
        Value<C001> CompositeUnitOfMeasure { get; }

        Value<decimal> PercentageAsDecimal { get; }
    }
}