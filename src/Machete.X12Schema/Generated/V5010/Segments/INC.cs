namespace Machete.X12Schema.V5010.Segments
{
    using Components;
    using X12;


    public interface INC :
        X12Segment
    {
        Value<string> TermsTypeCode { get; }
        
        Value<C001> CompositeUnitOfMeasure { get; }
        
        Value<decimal> Quantity1 { get; }
        
        Value<decimal> Quantity2 { get; }
        
        Value<decimal> MonetaryAmount { get; }
        
        Value<string> AmountQualifierCode { get; }
    }
}