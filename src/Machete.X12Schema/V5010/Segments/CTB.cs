namespace Machete.X12Schema.V5010
{
    using X12;


    public interface CTB :
        X12Segment
    {
        Value<string> RestrictionsOrConditionsQualifier { get; }
        
        Value<string> Description { get; }
        
        Value<string> QuantityQualifier { get; }
        
        Value<decimal> Quantity { get; }
        
        Value<string> AmountQualifier { get; }
        
        Value<decimal> Amount { get; }
        
        Value<C001> CompositeUnitOfMeasure { get; }
    }
}