namespace Machete.X12Schema.V5010
{
    using X12;


    public interface L0 :
        X12Segment
    {
        Value<int> LadingLineItemNumber { get; }
        
        Value<decimal> BilledOrRatedAsQuantity { get; }
        
        Value<string> BilledOrRatedAsQualifier { get; }
        
        Value<decimal> Weight { get; }
        
        Value<string> WeightQualifier { get; }
        
        Value<decimal> Volume { get; }
        
        Value<string> VolumeUnitQualifier { get; }
        
        Value<int> LadingQuantity { get; }
        
        Value<string> PackagingFormCode1 { get; }
        
        Value<string> DunnageDescription { get; }
        
        Value<string> WeightUnitCode { get; }
        
        Value<string> TypeOfServiceCode { get; }
        
        Value<decimal> Quantity { get; }
        
        Value<string> PackagingFormCode2 { get; }
        
        Value<string> YesNoConditionOrResponseCode { get; }
    }
}