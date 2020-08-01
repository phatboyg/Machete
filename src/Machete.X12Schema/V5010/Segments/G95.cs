namespace Machete.X12Schema.V5010
{
    using X12;


    public interface G95 :
        X12Segment
    {
        Value<string> PromotionConditionQualifier { get; }
        
        Value<string> PromotionConditionCode { get; }
        
        Value<int> AssignedNumber { get; }
        
        Value<decimal> Quantity { get; }
        
        Value<string> UnitOrBasisForMeasurement { get; }
        
        Value<string> Description { get; }
        
        Value<int> Number { get; }
    }
}