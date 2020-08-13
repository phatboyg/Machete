namespace Machete.X12Schema.V5010
{
    using X12;


    public interface AXL :
        X12Segment
    {
        Value<string> ProductOrServiceIdQualifier { get; }
        
        Value<string> ProductOrServiceId { get; }
        
        Value<string> MeasurementUnitQualifier { get; }
        
        Value<decimal> Length { get; }
        
        Value<decimal> Width { get; }
        
        Value<string> WeightQualifier { get; }
        
        Value<decimal> Weight { get; }
        
        Value<string> ReferenceIdentification { get; }
    }
}