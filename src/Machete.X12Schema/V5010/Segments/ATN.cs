namespace Machete.X12Schema.V5010
{
    using X12;


    public interface ATN :
        X12Segment
    {
        Value<decimal> Quantity { get; }
        
        Value<string> UnitOrBasisOfMeasurement { get; }
        
        Value<string> QuantityQualifier { get; }
        
        Value<string> FrequencyCode { get; }
        
        Value<string> AttendanceTypeCode { get; }
        
        Value<string> Description { get; }
    }
}