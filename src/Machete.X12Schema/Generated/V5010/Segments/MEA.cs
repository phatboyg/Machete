namespace Machete.X12Schema.V5010
{
    using X12;
    
    
    public interface MEA :
        X12Segment
    {
        Value<string> MeasurementReferenceIdentificationCode { get; }

        Value<string> MeasurementQualifier { get; }

        Value<decimal> MeasurementValue { get; }
    }
}