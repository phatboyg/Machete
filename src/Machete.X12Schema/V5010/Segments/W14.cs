namespace Machete.X12Schema.V5010
{
    using X12;


    public interface W14 :
        X12Segment
    {
        Value<decimal> QuantityReceived { get; }
        
        Value<decimal> NumberOfUnitsShipped { get; }
        
        Value<decimal> QuantityDamagedOrOnHold { get; }
        
        Value<int> LadingQuantityReceived { get; }
        
        Value<int> LadingQuantity { get; }
    }
}