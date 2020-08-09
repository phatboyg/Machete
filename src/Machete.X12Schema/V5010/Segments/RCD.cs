namespace Machete.X12Schema.V5010
{
    using X12;


    public interface RCD :
        X12Segment
    {
        Value<string> AssignedIdentification { get; }
        
        Value<decimal> QuantityUnitsReceivedOrAccepted { get; }
        
        Value<C001> CompositeUnitOfMeasure1 { get; }
        
        Value<decimal> QuantityUnitsReturned { get; }
        
        Value<C001> CompositeUnitOfMeasure2 { get; }
        
        Value<decimal> QuantityInQuestion1 { get; }
        
        Value<C001> CompositeUnitOfMeasure3 { get; }
        
        Value<string> ReceivingConditionCode1 { get; }
        
        Value<decimal> QuantityInQuestion2 { get; }
        
        Value<C001> CompositeUnitOfMeasure4 { get; }
        
        Value<string> ReceivingConditionCode2 { get; }
        
        Value<decimal> QuantityInQuestion3 { get; }
        
        Value<C001> CompositeUnitOfMeasure5 { get; }
        
        Value<string> ReceivingConditionCode3 { get; }
        
        Value<decimal> QuantityInQuestion4 { get; }
        
        Value<C001> CompositeUnitOfMeasure6 { get; }
        
        Value<string> ReceivingConditionCode4 { get; }
        
        Value<decimal> QuantityInQuestion5 { get; }
        
        Value<C001> CompositeUnitOfMeasure7 { get; }
        
        Value<string> ReceivingConditionCode5 { get; }
        
        Value<decimal> Quantity { get; }
    }
}