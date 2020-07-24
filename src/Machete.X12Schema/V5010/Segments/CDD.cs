namespace Machete.X12Schema.V5010
{
    using X12;


    public interface CDD :
        X12Segment
    {
        Value<string> AdjustmentReasonCode { get; }
        
        Value<string> CreditOrDebitFlagCode { get; }
        
        Value<string> AssignedIdentification { get; }
        
        Value<decimal> Amount { get; }
        
        Value<string> YesNoConditionOrResponseCode { get; }
        
        Value<string> PriceBracketIdentifier { get; }
        
        Value<decimal> CreditOrDebitQuantity { get; }

        Value<string> UnitOrBasisOfMeasurement { get; }
        
        Value<decimal> UnitPriceDifference { get; }
        
        Value<string> PriceIdentifierCode1 { get; }
        
        Value<decimal> UnitPrice1 { get; }
        
        Value<string> PriceIdentifierCode2 { get; }
        
        Value<decimal> UnitPrice2 { get; }
    }
}