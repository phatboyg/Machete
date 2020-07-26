namespace Machete.X12Schema.V5010
{
    using X12;


    public interface ADV :
        X12Segment
    {
        Value<string> AgencyQualifierCode { get; }
        
        Value<string> ServiceCharacteristicsQualifier1 { get; }
        
        Value<decimal> RangeMinimum { get; }
        
        Value<decimal> RangeMaximum { get; }
        
        Value<string> Category { get; }
        
        Value<string> ServiceCharacteristicsQualifier2 { get; }
        
        Value<decimal> MeasurementValue { get; }
    }
}